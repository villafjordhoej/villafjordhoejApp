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
	    public List<Object> SyvDagsBookings { get; set; }




		public VM_Booking()
		{
            SyvDagsBookings = new List<Object>();


			//Opretter et instance af singleton
			BookingSingleton = Singleton.GetInstance;

            //
            BookingSingleton.LoadBookings();
            BookingSingleton.LoadGaests();

            FindSyvDageBookings();
        }


	    public void FindSyvDageBookings()
	    {
	        var LinqQuery1 = from Booking in BookingSingleton.Bookings
                             join Gaest in BookingSingleton.Gaests on Booking.booking_gaest_id equals Gaest.gaest_id
                             where Booking.booking_ankomst <= DateTime.Now.AddDays(7.0) && Booking.booking_ankomst >= DateTime.Now
                             select new { booking = Booking, gaest = Gaest };

            foreach (var B in LinqQuery1)
	        {
	            SyvDagsBookings.Add(B);
	        }

	    }

	}
}
