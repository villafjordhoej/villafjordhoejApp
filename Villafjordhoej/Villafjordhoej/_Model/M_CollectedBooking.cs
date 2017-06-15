using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_CollectedBooking
    {

        public M_Gaest Gaest { get; set; } 
        public M_CollectedVaerelser CVaerelse { get; set; }
        public string all { get; set; }


        public M_CollectedBooking(M_Gaest gaest, M_CollectedVaerelser cVaerelse, string all)
        {
            Gaest = gaest;
            CVaerelse = cVaerelse;
            this.all = all;
        }
        
    }
}
