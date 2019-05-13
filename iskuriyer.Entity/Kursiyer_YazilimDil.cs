namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[Kursiyer.YazilimDil]")]
    public partial class Kursiyer_YazilimDil
    {
        public int ID { get; set; }

        [StringLength(15)]
        public string Adi { get; set; }

        public short? Seviye { get; set; }

        public int? KursiyerID { get; set; }

        public virtual Kursiyer Kursiyer { get; set; }
    }
}
