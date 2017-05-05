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

        public decimal? m_vaerelser_aftalt_pris { get; set; }

        public Me_Vaerelser(int mVaerelserId, int? mVaerelserBookingId, int? mVaerelserVaerelserId, decimal? mVaerelserAftaltPris)
        {
            m_vaerelser_id = mVaerelserId;
            m_vaerelser_booking_id = mVaerelserBookingId;
            m_vaerelser_vaerelser_id = mVaerelserVaerelserId;
            m_vaerelser_aftalt_pris = mVaerelserAftaltPris;
        }

        public override string ToString()
        {
            return $"{nameof(m_vaerelser_id)}: {m_vaerelser_id}, {nameof(m_vaerelser_booking_id)}: {m_vaerelser_booking_id}, {nameof(m_vaerelser_vaerelser_id)}: {m_vaerelser_vaerelser_id}, {nameof(m_vaerelser_aftalt_pris)}: {m_vaerelser_aftalt_pris}";
        }
    }
}
