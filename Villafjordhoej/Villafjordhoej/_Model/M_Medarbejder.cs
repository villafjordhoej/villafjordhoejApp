using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_Medarbejder
    {
        public int medarbejder_id { get; set; }
        
        public string medarbejder_navn { get; set; }
        
        public string medarbejder_adresse { get; set; }

        public M_Medarbejder(string medarbejderNavn, string medarbejderAdresse)
        {
            medarbejder_navn = medarbejderNavn;
            medarbejder_adresse = medarbejderAdresse;
        }

        public override string ToString()
        {
            return $"{nameof(medarbejder_id)}: {medarbejder_id}, {nameof(medarbejder_navn)}: {medarbejder_navn}, {nameof(medarbejder_adresse)}: {medarbejder_adresse}";
        }
    }
}
