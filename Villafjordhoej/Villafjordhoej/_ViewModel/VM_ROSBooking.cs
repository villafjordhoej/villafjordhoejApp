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
using EventMaker.Converter;
using Villafjordhoej.Annotations;
using Villafjordhoej.Exceptions;
using Villafjordhoej.Handler;
using Villafjordhoej.Persistency;
using Villafjordhoej._Model;
using Villafjordhoej._View;

namespace Villafjordhoej._ViewModel
{
    class VM_ROSBooking : INotifyPropertyChanged
    {
        //indeholder et instance af singleton
        public Singleton BookingSingleton { get; set; }

        public M_Booking MBooking { get; set; }

        public string Name { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public int TelefonNr { get; set; }

        public int AntalPersoner { get; set; }
        public DateTimeOffset Ankomst { get; set; }
        public DateTimeOffset Afrejse { get; set; }
        public string Allergener { get; set; }
        public string Information { get; set; }
        public double AftaltPris { get; set; }


        public TimeSpan ZeroTime = TimeSpan.Zero;


        public RelayCommand RC_Opret { get; set; }
        //public RelayCommand RC_Rediger { get; set; }
        //public RelayCommand RC_Slet { get; set; }


        //skal tage sig af ROS Booking view
        public VM_ROSBooking()
        {
            Ankomst = DateTimeOffset.Now;
            Afrejse = DateTimeOffset.Now;

            BookingSingleton = Singleton.GetInstance;

            BookingSingleton.LoadVaerelser();
            BookingSingleton.LoadGaests();
            BookingSingleton.LoadMeVaerelsers();


            RC_Opret = new RelayCommand(Opret);
            //RC_Rediger = new RelayCommand(Rediger);
            //RC_Slet = new RelayCommand(Slet);

        }

        private void Opret()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Allergener))
            {
                try
                {
                    if (string.IsNullOrEmpty(Name)  && string.IsNullOrEmpty(Allergener))
                    {
                        throw new MulipleIsNullException("Navn og Allergener må IKKE være tomme");
                    }
                    else if (string.IsNullOrEmpty(Name))
                    {
                        throw new NameIsNullException("Navn må IKKE være tom");
                    }
                    else
                    {
                        throw new AllergenerIsNullException("Allergener må IKKE være tom");
                    }
                }
                catch (Exception ex)
                {
                    new MessageDialog(ex.Message).ShowAsync();
                }
                    
            }
	        else
	        {
                //Gemmer en ny Gæst i databasen til brug i booking nedeunder
                BookingSingleton.SaveGaests(new M_Gaest(Name, Adresse, TelefonNr, Email));


                //Gemmer en ny booking (i DB) som skal bruges nedeunder også
                BookingSingleton.SaveBookings(new M_Booking(
                    BookingSingleton.Gaests.Last().gaest_id,
                    DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(Ankomst, ZeroTime),
                    DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(Afrejse, ZeroTime),
                    Allergener, Information, DateTime.Now, BookingSingleton.LogInMedarbejderId, AntalPersoner, Convert.ToDecimal(AftaltPris)));


                //Gemmer alle værseler du har valgt til bookingen i DB
                foreach (M_Vaerelse V in BookingSingleton.Vaerelser)
                {
                    if (V.CheckBoxIsChecked)
                    {
                        BookingSingleton.SaveMeVaerelsers(new Me_Vaerelser(BookingSingleton.BookingsCurrentID, V.vaerelse_id));
                    }
                }
            }

        }

	    private void Rediger()
	    {
	       
	    }

	    private void Slet()
	    {
	        
	    }




        #region PCS
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged ([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this , new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
