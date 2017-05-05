using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_Vaerelse
    {

        public int vaerelse_id { get; set; }
        public string vaerelse_navn { get; set; }
        public double vaerelse_pris { get; set; }
        public int vaerelse_antalpladser { get; set; }


        public M_Vaerelse(int vaerelseAntalpladser, int vaerelseId, string vaerelseNavn, double vaerelsePris)
        {
            vaerelse_id = vaerelseId;
            vaerelse_navn = vaerelseNavn;
            vaerelse_pris = vaerelsePris;
            vaerelse_antalpladser = vaerelseAntalpladser;
        }


        public override string ToString()
        {
            return $"{nameof(vaerelse_id)}: {vaerelse_id}, {nameof(vaerelse_navn)}: {vaerelse_navn}, {nameof(vaerelse_pris)}: {vaerelse_pris}, {nameof(vaerelse_antalpladser)}: {vaerelse_antalpladser}";
        }
    }
}
