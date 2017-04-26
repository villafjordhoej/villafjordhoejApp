using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_Behandling
    {
        public string Name { get; set; }
        public string Beskrivelse { get; set; }
        public double Pris { get; set; }
        public bool Boolhandler { get; set; }


        public M_Behandling(string name, string beskrivelse, double pris, bool boolhandler)
        {
            Name = name;
            Beskrivelse = beskrivelse;
            Pris = pris;
            Boolhandler = boolhandler;
        }


        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Beskrivelse)}: {Beskrivelse}, {nameof(Pris)}: {Pris}, {nameof(Boolhandler)}: {Boolhandler}";
        }
    }
}
