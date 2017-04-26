using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
	class M_Booking
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string TelefonNr { get; set; }
		public string Allergener { get; set; }
		public string Information { get; set; }
		public int AntalPersoner { get; set; }
		public List<M_Room> Rooms { get; set; }
		public DateTime Ankomst { get; set; }
		public DateTime Afrejse { get; set; }

		public M_Booking(string name, string email, string tlfnr, string allergener, string info, 
			int antalpersoner, DateTime ankomst, DateTime afrejse)
		{
			Name = name;
			Email = email;
			TelefonNr = tlfnr;
			Allergener = allergener;
			Information = info;
			AntalPersoner = antalpersoner;
			Ankomst = ankomst;
			Afrejse = afrejse;
		}
		
	}
}
