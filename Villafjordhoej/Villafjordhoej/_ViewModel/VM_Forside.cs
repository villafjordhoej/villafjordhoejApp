using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Villafjordhoej._ViewModel
{
	class VM_Forside
	{
		//Sørger for visibility på knapper
		public Visibility BookingKnapULoginVisibility { get; set; }

		public VM_Forside()
		{
			//Sætter booking knap Uden login til visible ***********(TEST)********
			BookingKnapULoginVisibility = Visibility.Visible;
		}
	}
}
