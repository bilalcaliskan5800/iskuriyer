namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[Kursiyer.Deneyim]")]
    public partial class Kursiyer_Deneyim
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string SirketAdi { get; set; }

        [StringLength(30)]
        public string Pozisyon { get; set; }

        public short? CalismaSuresi { get; set; }

        public int? KursiyerID { get; set; }

        public virtual Kursiyer Kursiyer { get; set; }
    }
}
