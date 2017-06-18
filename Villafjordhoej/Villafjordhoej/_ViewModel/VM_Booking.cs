using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Villafjordhoej.Annotations;
using Villafjordhoej.Handler;
using Villafjordhoej.Persistency;
using Villafjordhoej._Model;
using WinRTXamlToolkit.Tools;

namespace Villafjordhoej._ViewModel
{
	//Skal kun kører Booking view
	class VM_Booking : INotifyPropertyChanged
	{
        #region Property Changed
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion




        //indeholder et instance af singleton
        public Singleton BookingSingleton { get; set; }
	    public ObservableCollection<M_CollectedBooking> SyvDagsBookings { get; set; }
	    public int SelectedSyvDagsID { get; set; }


	    public RelayCommand RC_Slet { get; set; }






        public VM_Booking()
		{
            SyvDagsBookings = new ObservableCollection<M_CollectedBooking>();
		    SelectedSyvDagsID = -1;


            //Opretter et instance af singleton
            BookingSingleton = Singleton.GetInstance;

            //
            BookingSingleton.LoadBookings();
            BookingSingleton.LoadGaests();
            BookingSingleton.LoadMeVaerelsers();
            BookingSingleton.LoadVaerelser();
		    


            FindSyvDageBookings();

            RC_Slet = new RelayCommand(SletBookingFromDBAndList);
        }


	    public void FindSyvDageBookings()
	    {
	        var LinqQuery1 = from Mellem in BookingSingleton.Mellem_Vaerelsers
	            join Vaerelse in BookingSingleton.Vaerelser on Mellem.m_vaerelser_vaerelser_id equals Vaerelse.vaerelse_id
	            select new M_CollectedMellemVaerelser(Mellem, Vaerelse);


            var LinqQuery2 = from Booking in BookingSingleton.Bookings
                               join mel in LinqQuery1 on Booking.booking_id equals mel.MeVaerelser.m_vaerelser_booking_id into v
                               select new M_CollectedVaerelser(Booking, new List<M_CollectedMellemVaerelser>(v));

            var LinqQuery3 = from Booking in LinqQuery2
                             join Gaest in BookingSingleton.Gaests on Booking.Booking.booking_gaest_id equals Gaest.gaest_id
                             where Booking.Booking.booking_ankomst <= DateTime.Now.AddDays(7.0) && Booking.Booking.booking_ankomst >= DateTime.Today.AddDays(-1)
                             orderby Booking.Booking.booking_ankomst
                             select new M_CollectedBooking(Gaest, new M_CollectedVaerelser(Booking.Booking, Booking.MellemV), string.Join(", ", from item in Booking.MellemV select item.MVaerelse.vaerelse_navn));

            //select new { booking = Booking, gaest = Gaest, all = string.Join(", ", from item in Booking.Ve select item.v.vaerelse_navn )};

            foreach (var B in LinqQuery3)
            {
                SyvDagsBookings.Add(B);
	        }

	    }

	    public void SletBookingFromDBAndList()
	    {

            if (SelectedSyvDagsID != -1)
	        {
                BookingSingleton.DeleteBooking(SyvDagsBookings[SelectedSyvDagsID].CVaerelse.Booking);
	            foreach (var mellemVaerelser in SyvDagsBookings[SelectedSyvDagsID].CVaerelse.MellemV)
	            {
	                BookingSingleton.DeleteMeVearelser(mellemVaerelser.MeVaerelser);
	            }

                SyvDagsBookings.RemoveAt(SelectedSyvDagsID); OnPropertyChanged();

                new MessageDialog("Bookingen blev slettet").ShowAsync();


            }
	        else
	        {
                new MessageDialog("Du har ikke valgt en booking!").ShowAsync();
            }


        }


        
    }
}
