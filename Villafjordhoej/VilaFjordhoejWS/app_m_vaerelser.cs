namespace VilaFjordhoejWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class app_m_vaerelser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int m_vaerelser_id { get; set; }

        public int? m_vaerelser_booking_id { get; set; }

        public int? m_vaerelser_vaerelser_id { get; set; }

        public decimal? m_vaerelser_aftalt_pris { get; set; }
    }
}
