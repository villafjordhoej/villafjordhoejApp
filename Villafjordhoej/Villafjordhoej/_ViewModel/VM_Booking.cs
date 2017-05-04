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

		public VM_Booking()
		{
			//Opretter et instance af singleton
			BookingSingleton = Singleton.GetInstance;
			BookingSingleton.LoadMeVaerelsers();
		}
	}
}
