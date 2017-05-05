using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villafjordhoej.Handler;
using Villafjordhoej._Model;

namespace Villafjordhoej._ViewModel
{
	class VM_AdminMedarbejdere
	{
		//Indeholder et instance af singleton
		public Singleton MedarbejderSingleton { get; set; }

		//Tekstbokse på view
		public string Name { get; set; }
		public string Password { get; set; }

		//RelayCommands til knapper
		public RelayCommand OpretMedarbejderRelayCommand { get; set; }
		public RelayCommand SletMedarbejderRelayCommand { get; set; }

		public VM_AdminMedarbejdere()
		{
			//Opretter et instance af singleton 
			//og henter medarbejder listen fra DB (Via singleton)
			MedarbejderSingleton = Singleton.GetInstance;
			MedarbejderSingleton.LoadMedarbejders();

			//opretter knap funktion
			OpretMedarbejderRelayCommand = new RelayCommand(OpretMedarbejder);
			SletMedarbejderRelayCommand = new RelayCommand(SletMedarbejder);
		}

		//Sletter en medarbejder
		private void SletMedarbejder()
		{
			//Manger funktion i singleton
		}

		//Opretter en medarbejder
		private void OpretMedarbejder()
		{
			//MedarbejderSingleton.SaveMedarbejders(new M_Medarbejder(Name, Password));
		}
	}
}
