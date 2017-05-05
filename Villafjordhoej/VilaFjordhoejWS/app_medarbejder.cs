namespace VilaFjordhoejWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class app_medarbejder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int medarbejder_id { get; set; }

        [StringLength(50)]
        public string medarbejder_navn { get; set; }

        [StringLength(50)]
        public string medarbejder_adresse { get; set; }
    }
}
