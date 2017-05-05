using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class Me_Vaerelser
    {
        public int me_vaerelser_id { get; set; }
        public int me_vaerelser_booking_id { get; set; }
        public int me_vaerelser_vaerelser_id { get; set; }
        public double me_vaerelser_aftalt_pris { get; set; }

        public Me_Vaerelser()
        {
            
        }

        public override string ToString()
        {
            return $"{nameof(me_vaerelser_id)}: {me_vaerelser_id}, {nameof(me_vaerelser_booking_id)}: {me_vaerelser_booking_id}, {nameof(me_vaerelser_vaerelser_id)}: {me_vaerelser_vaerelser_id}, {nameof(me_vaerelser_aftalt_pris)}: {me_vaerelser_aftalt_pris}";
        }
    }
}
