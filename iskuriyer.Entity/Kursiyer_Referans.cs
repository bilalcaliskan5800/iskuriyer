namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[Kursiyer.Referans]")]
    public partial class Kursiyer_Referans
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Ad { get; set; }

        [StringLength(15)]
        public string Soyad { get; set; }

        [StringLength(11)]
        public string Telefon { get; set; }

        [StringLength(150)]
        public string EPosta { get; set; }

        public int? KursiyerID { get; set; }

        public virtual Kursiyer Kursiyer { get; set; }
    }
}
