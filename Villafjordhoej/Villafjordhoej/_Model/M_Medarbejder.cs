using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_Medarbejder
    {
        public string Name { get; set; }
        public string Password { get; set; }


        public M_Medarbejder(string name, string pass)
        {
            Name = name;
            Password = pass;    
        }            


    }
}
