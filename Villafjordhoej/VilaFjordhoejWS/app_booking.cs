namespace VilaFjordhoejWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class app_booking
    {
        [Key]
        public int booking_id { get; set; }

        public int? booking_gaest_id { get; set; }

        public int? booking_antalpersoner { get; set; }

        public DateTime? booking_ankomst { get; set; }

        public DateTime? booking_afrejse { get; set; }

        [Column(TypeName = "text")]
        public string booking_allergener { get; set; }

        [StringLength(10)]
        public string booking_information { get; set; }

        public DateTime? booking_modtaget_dato { get; set; }

        public int? booking_modtaget_id { get; set; }

        public decimal? booking_aftaltpris { get; set; }
    }
}
