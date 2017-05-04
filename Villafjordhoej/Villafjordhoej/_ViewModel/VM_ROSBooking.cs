using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villafjordhoej.Persistency;
using Villafjordhoej._Model;

namespace Villafjordhoej._ViewModel
{
	class VM_ROSBooking
	{
		//indeholder et instance af singleton
		public Singleton BookingSingelton { get; set; }
		//skal tage sig af ROS Booking view
		public VM_ROSBooking()
		{
			BookingSingelton = Singleton.GetInstance;
		}
	}
}
