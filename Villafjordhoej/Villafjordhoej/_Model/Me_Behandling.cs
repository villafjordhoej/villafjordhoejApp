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
        public int m_behandling_id { get; set; }

        public int? m_behandling_behandling_id { get; set; }

        public int? m_behandling_booking_id { get; set; }

        public DateTime? m_behandling_datetime { get; set; }

        public Me_Behandling(int mBehandlingId, int? mBehandlingBehandlingId, int? mBehandlingBookingId, DateTime? mBehandlingDatetime)
        {
            m_behandling_id = mBehandlingId;
            m_behandling_behandling_id = mBehandlingBehandlingId;
            m_behandling_booking_id = mBehandlingBookingId;
            m_behandling_datetime = mBehandlingDatetime;
        }

        public override string ToString()
        {
            return $"{nameof(m_behandling_id)}: {m_behandling_id}, {nameof(m_behandling_behandling_id)}: {m_behandling_behandling_id}, {nameof(m_behandling_booking_id)}: {m_behandling_booking_id}, {nameof(m_behandling_datetime)}: {m_behandling_datetime}";
        }
    }
}
