namespace VilefjordhoejWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class app_behandlinger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int behandlinger_id { get; set; }

        [StringLength(20)]
        public string behandlinger_navn { get; set; }

        [Column(TypeName = "text")]
        public string behandlinger_beskrivelse { get; set; }

        public decimal? behandlinger_pris { get; set; }

        public byte? behandlinger_boolbehandler { get; set; }
    }
}
