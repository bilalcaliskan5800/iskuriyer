namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Iller")]
    public partial class Iller
    {
        public int id { get; set; }

        [StringLength(255)]
        public string sehir { get; set; }
    }
}
