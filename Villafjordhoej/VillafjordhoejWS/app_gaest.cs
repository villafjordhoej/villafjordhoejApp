namespace VillafjordhoejWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class app_gaest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gaest_id { get; set; }

        [StringLength(50)]
        public string gaest_navn { get; set; }

        [StringLength(50)]
        public string gaest_adresse { get; set; }

        public int? gaest_tlf { get; set; }

        [StringLength(50)]
        public string gaest_mail { get; set; }
    }
}
