namespace VilaFjordhoejWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class app_vaerelse
    {
        [Key]
        public int vaerelse_id { get; set; }

        [StringLength(50)]
        public string vaerelse_navn { get; set; }

        public decimal? vaerelse_pris { get; set; }

        public byte? vaerelse_antalpladser { get; set; }
    }
}
