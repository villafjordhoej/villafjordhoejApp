using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villafjordhoej.Handler;
using Villafjordhoej._Model;

namespace Villafjordhoej._ViewModel
{
	class VM_AdminBehandling
	{
		//Indeholder et instance af singleton
		public Singleton ABehandlingSingleton { get; set; }

		//Props til View
		public string Navn { get; set; }
		public string Beskrivelse { get; set; }
		public double Pris { get; set; }

		//RelayCommands
		public RelayCommand OpretBehandlingRelayCommand { get; set; }
		public RelayCommand RedigerBehandlingRelayCommand { get; set; }
		public RelayCommand SletBehandlingRelayCommand { get; set; }

		//Bool behandler ved ikke hvad den gør / skal gøre / er?!
		public Boolean Behandler { get; set; }

		public VM_AdminBehandling()
		{
			//Opretter et instance af singleton og loader behandlings listen
			ABehandlingSingleton = Singleton.GetInstance;
			ABehandlingSingleton.LoadBehandlings();

			OpretBehandlingRelayCommand = new RelayCommand(OpretBehandling);
			RedigerBehandlingRelayCommand = new RelayCommand(RedigerBehandling);
			SletBehandlingRelayCommand = new RelayCommand(SletBehandling);
		}

		private void OpretBehandling()
		{
			//ABehandlingSingleton.SaveBehandlings(new M_Behandling
			//	(ABehandlingSingleton.BehandlingId, Navn, Beskrivelse, 
			//	Convert.ToDecimal(Pris), Convert.ToByte(false)));
		}

		private void RedigerBehandling()
		{
			SletBehandling();
			OpretBehandling();
		}

		private void SletBehandling()
		{
			//Mangler implementation på singleton
		}
	}
}
