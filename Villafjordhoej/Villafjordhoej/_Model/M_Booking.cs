using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
	class M_Booking
	{
        
        public int booking_id { get; set; }

        public int? booking_gaest_id { get; set; }

        public DateTime? booking_ankomst { get; set; }

        public DateTime? booking_afrejse { get; set; }
        
        public string booking_allergener { get; set; }
        
        public string booking_information { get; set; }

        public DateTime? booking_modtaget_dato { get; set; }

        public int? booking_modtaget_id { get; set; }

	    public M_Booking(int bookingId, int? bookingGaestId, DateTime? bookingAnkomst, DateTime? bookingAfrejse, string bookingAllergener, string bookingInformation, DateTime? bookingModtagetDato, int? bookingModtagetId)
	    {
	        booking_id = bookingId;
	        booking_gaest_id = bookingGaestId;
	        booking_ankomst = bookingAnkomst;
	        booking_afrejse = bookingAfrejse;
	        booking_allergener = bookingAllergener;
	        booking_information = bookingInformation;
	        booking_modtaget_dato = bookingModtagetDato;
	        booking_modtaget_id = bookingModtagetId;
	    }

	    public override string ToString()
	    {
	        return $"{nameof(booking_id)}: {booking_id}, {nameof(booking_gaest_id)}: {booking_gaest_id}, {nameof(booking_ankomst)}: {booking_ankomst}, {nameof(booking_afrejse)}: {booking_afrejse}, {nameof(booking_allergener)}: {booking_allergener}, {nameof(booking_information)}: {booking_information}, {nameof(booking_modtaget_dato)}: {booking_modtaget_dato}, {nameof(booking_modtaget_id)}: {booking_modtaget_id}";
	    }
	}
}
