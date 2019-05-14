namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[Kursiyer.Egitim]")]
    public partial class Kursiyer_Egitim
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string Adi { get; set; }

        [StringLength(30)]
        public string Bolumu { get; set; }

        public short? Derece { get; set; }

        public int? KursiyerID { get; set; }

        public virtual Kursiyer Kursiyer { get; set; }
    }
}
