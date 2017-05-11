using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_Behandling
    {
        
        public int behandlinger_id { get; set; }

        public string behandlinger_navn { get; set; }

        public string behandlinger_beskrivelse { get; set; }

        public decimal? behandlinger_pris { get; set; }

        public byte? behandlinger_boolbehandler { get; set; }

        public M_Behandling(string behandlingerNavn, string behandlingerBeskrivelse, decimal? behandlingerPris, byte? behandlingerBoolbehandler)
        {
            behandlinger_navn = behandlingerNavn;
            behandlinger_beskrivelse = behandlingerBeskrivelse;
            behandlinger_pris = behandlingerPris;
            behandlinger_boolbehandler = behandlingerBoolbehandler;
        }

        public override string ToString()
        {
            return $"{nameof(behandlinger_id)}: {behandlinger_id}, {nameof(behandlinger_navn)}: {behandlinger_navn}, {nameof(behandlinger_beskrivelse)}: {behandlinger_beskrivelse}, {nameof(behandlinger_pris)}: {behandlinger_pris}, {nameof(behandlinger_boolbehandler)}: {behandlinger_boolbehandler}";
        }
    }
}
