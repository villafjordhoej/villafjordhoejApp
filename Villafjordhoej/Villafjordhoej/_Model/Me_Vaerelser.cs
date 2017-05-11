using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class Me_Vaerelser
    {
        public int m_vaerelser_id { get; set; }

        public int? m_vaerelser_booking_id { get; set; }

        public int? m_vaerelser_vaerelser_id { get; set; }
        

        public Me_Vaerelser(int? mVaerelserBookingId, int? mVaerelserVaerelserId)
        {
            m_vaerelser_booking_id = mVaerelserBookingId;
            m_vaerelser_vaerelser_id = mVaerelserVaerelserId;
        }

        public override string ToString()
        {
            return $"{nameof(m_vaerelser_id)}: {m_vaerelser_id}, {nameof(m_vaerelser_booking_id)}: {m_vaerelser_booking_id}, {nameof(m_vaerelser_vaerelser_id)}: {m_vaerelser_vaerelser_id}";
        }
    }
}
