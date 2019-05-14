namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[Kursiyer.Yetenek]")]
    public partial class Kursiyer_Yetenek
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Adi { get; set; }

        public int? KursiyerID { get; set; }

        public virtual Kursiyer Kursiyer { get; set; }
    }
}
