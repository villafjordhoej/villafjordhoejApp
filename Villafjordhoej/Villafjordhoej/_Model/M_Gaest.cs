using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_Gaest
    {
        public int gaest_id { get; set; }
        
        public string gaest_navn { get; set; }
        
        public string gaest_adresse { get; set; }

        public int gaest_tlf { get; set; }
        
        public string gaest_mail { get; set; }

        public M_Gaest(int gaestId, string gaestNavn, string gaestAdresse, int gaestTlf, string gaestMail)
        {
            gaest_id = gaestId;
            gaest_navn = gaestNavn;
            gaest_adresse = gaestAdresse;
            gaest_tlf = gaestTlf;
            gaest_mail = gaestMail;
        }

        public override string ToString()
        {
            return $"{nameof(gaest_id)}: {gaest_id}, {nameof(gaest_navn)}: {gaest_navn}, {nameof(gaest_adresse)}: {gaest_adresse}, {nameof(gaest_tlf)}: {gaest_tlf}, {nameof(gaest_mail)}: {gaest_mail}";
        }
    }
}
