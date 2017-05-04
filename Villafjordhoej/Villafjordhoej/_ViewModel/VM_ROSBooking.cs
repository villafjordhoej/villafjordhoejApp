using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villafjordhoej.Handler;
using Villafjordhoej.Persistency;
using Villafjordhoej._Model;
using Villafjordhoej._View;

namespace Villafjordhoej._ViewModel
{
	class VM_ROSBooking
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
	    }

	    private void Opret()
	    {
	        BookingSingleton.SaveBookings(new M_Booking(Name, Email, TelefonNr, Allergener, Information, AntalPersoner, Ankomst, Afrejse));   
	    }
        
	}
}
