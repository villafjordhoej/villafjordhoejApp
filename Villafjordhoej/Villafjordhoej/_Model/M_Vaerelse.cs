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

        public decimal? vaerelse_pris { get; set; }

        public byte? vaerelse_antalpladser { get; set; }

        public bool CheckBoxIsChecked { get; set; }



        public M_Vaerelse(int vaerelseId, string vaerelseNavn, decimal? vaerelsePris, byte? vaerelseAntalpladser)
        {
            vaerelse_id = vaerelseId;
            vaerelse_navn = vaerelseNavn;
            vaerelse_pris = vaerelsePris;
            vaerelse_antalpladser = vaerelseAntalpladser;

            CheckBoxIsChecked = false;
        }

        public override string ToString()
        {
            return $"{nameof(vaerelse_id)}: {vaerelse_id}, {nameof(vaerelse_navn)}: {vaerelse_navn}, {nameof(vaerelse_pris)}: {vaerelse_pris}, {nameof(vaerelse_antalpladser)}: {vaerelse_antalpladser}";
        }
    }
}
