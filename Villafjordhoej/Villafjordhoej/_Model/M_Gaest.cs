using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_Gaest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Tlf { get; set; }
        public string Email { get; set; }


        public M_Gaest(string name, string address, int tlf, string email)
        {
            Name = name;
            Address = address;
            Tlf = tlf;
            Email = email;
        }


        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}, {nameof(Tlf)}: {Tlf}, {nameof(Email)}: {Email}";
        }
    }
}
