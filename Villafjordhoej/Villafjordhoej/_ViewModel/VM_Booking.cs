using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villafjordhoej.Persistency;
using Villafjordhoej._Model;

namespace Villafjordhoej._ViewModel
{
	//Skal kun kører Booking view
	class VM_Booking
	{
		//indeholder et instance af singleton
		public Singleton BookingSingleton { get; set; }
	    public List<M_Booking> SyvDagsBookings { get; set; }




		public VM_Booking()
		{
            SyvDagsBookings = new List<M_Booking>();


			//Opretter et instance af singleton
			BookingSingleton = Singleton.GetInstance;
            BookingSingleton.LoadBookings();

            FindSyvDageBookings();
        }


	    public void FindSyvDageBookings()
	    {
	        var LinqQuery1 = from Booking in BookingSingleton.Bookings
	            where Booking.booking_ankomst <= DateTime.Now.AddDays(7.0) && Booking.booking_ankomst >= DateTime.Now
	            select Booking;

	        foreach (M_Booking B in LinqQuery1)
	        {
	            SyvDagsBookings.Add(B);
	        }

	    }

	}
}
