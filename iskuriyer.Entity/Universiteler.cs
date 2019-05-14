namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Universiteler")]
    public partial class Universiteler
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Ad { get; set; }
    }
}
