using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_CollectedVaerelser
    {
        public M_Booking Booking { get; set; }
        public List<M_CollectedMellemVaerelser> MellemV { get; set; }

        public M_CollectedVaerelser(M_Booking booking, List<M_CollectedMellemVaerelser> mellemV)
        {
            Booking = booking;
            MellemV = mellemV;
        }
    }
}
