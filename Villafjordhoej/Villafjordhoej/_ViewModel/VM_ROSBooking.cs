using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Villafjordhoej.Annotations;
using Villafjordhoej.Handler;
using Villafjordhoej.Persistency;
using Villafjordhoej._Model;
using Villafjordhoej._View;

namespace Villafjordhoej._ViewModel
{
	class VM_ROSBooking    : INotifyPropertyChanged
	{
		//indeholder et instance af singleton
	    public Singleton BookingSingleton { get; set; }
	    public M_Booking MBooking { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelefonNr { get; set; }
        public string Allergener { get; set; }
        public string Information { get; set; }
        public int AntalPersoner { get; set; }
        public List<M_Vaerelse> Rooms { get; set; }
        public DateTime Ankomst { get; set; }
        public DateTime Afrejse { get; set; }

	    public RelayCommand RC_Opret { get; set; }

        //skal tage sig af ROS Booking view
	    public VM_ROSBooking()
	    {
	        BookingSingleton = Singleton.GetInstance;
            RC_Opret = new RelayCommand(Opret);   
	    }

	    private void Opret()
	    {
	        BookingSingleton.SaveBookings(new M_Booking(Name, Email, TelefonNr, Allergener, Information, AntalPersoner, Ankomst, Afrejse));   
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
