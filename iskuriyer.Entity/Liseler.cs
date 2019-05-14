namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Liseler")]
    public partial class Liseler
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string Ad { get; set; }
    }
}
