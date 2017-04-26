using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_Room
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int NrSpaces { get; set; }
        public string Information { get; set; }

        public M_Room(string name, double price, int nrSpaces, string information)
        {
            Name = name;
            Price = price;
            NrSpaces = nrSpaces;
            Information = information;
        }


        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Price)}: {Price}, {nameof(NrSpaces)}: {NrSpaces}";
        }
    }
}
