namespace VilaFjordhoejWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class app_m_behandling
    {
        [Key]
        public int m_behandling_id { get; set; }

        public int? m_behandling_behandling_id { get; set; }

        public int? m_behandling_booking_id { get; set; }

        public DateTime? m_behandling_datetime { get; set; }
    }
}
