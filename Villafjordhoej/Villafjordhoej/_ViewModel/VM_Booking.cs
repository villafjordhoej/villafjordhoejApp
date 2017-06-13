using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villafjordhoej.Persistency;
using Villafjordhoej._Model;
using WinRTXamlToolkit.Tools;

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
            BookingSingleton.LoadMeVaerelsers();
            BookingSingleton.LoadVaerelser();
		    


            FindSyvDageBookings();
        }


	    public void FindSyvDageBookings()
	    {
	        var LinqQuery1 = from Mellem in BookingSingleton.Mellem_Vaerelsers
	            join Vaerelse in BookingSingleton.Vaerelser on Mellem.m_vaerelser_vaerelser_id equals Vaerelse.vaerelse_id
	            select new {me = Mellem, v = Vaerelse};


            var LinqQuery2 = from Booking in BookingSingleton.Bookings
                               join mel in LinqQuery1 on Booking.booking_id equals mel.me.m_vaerelser_booking_id into v
                               select new {bo = Booking, Ve = v};

            var LinqQuery3 = from Booking in LinqQuery2
                             join Gaest in BookingSingleton.Gaests on Booking.bo.booking_gaest_id equals Gaest.gaest_id
                             where Booking.bo.booking_ankomst <= DateTime.Now.AddDays(7.0) && Booking.bo.booking_ankomst >= DateTime.Today.AddDays(-1)
                             orderby Booking.bo.booking_ankomst
                             select new { booking = Booking, gaest = Gaest, all = string.Join(", ", from item in Booking.Ve select item.v.vaerelse_navn )};

            foreach (var B in LinqQuery3)
            {
                SyvDagsBookings.Add(B);
	        }

	    }

	}
}
