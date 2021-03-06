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

        public int? KursiyerID { get; set; }

        public int? YetenekID { get; set; }

        public virtual Kursiyer Kursiyer { get; set; }

        public virtual Yetenek Yetenek { get; set; }
    }
}
