using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace Villafjordhoej._Model
{
    class Me_Behandling
    {
        public int me_behandling_id { get; set; }
        public int me_behandling_behandling_id { get; set; }
        public int me_behandling_booking_id { get; set; }
        public DateTime me_behandling_datetime { get; set; }

        public Me_Behandling()
        {
            
        }


        public override string ToString()
        {
            return $"{nameof(me_behandling_id)}: {me_behandling_id}, {nameof(me_behandling_behandling_id)}: {me_behandling_behandling_id}, {nameof(me_behandling_booking_id)}: {me_behandling_booking_id}, {nameof(me_behandling_datetime)}: {me_behandling_datetime}";
        }
    }
}
