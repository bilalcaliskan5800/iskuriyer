namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[Kursiyer.Iletisim]")]
    public partial class Kursiyer_Iletisim
    {
        public int ID { get; set; }

        [StringLength(11)]
        public string TelefonNo { get; set; }

        [StringLength(150)]
        public string EPosta { get; set; }

        public int? KursiyerID { get; set; }

        public virtual Kursiyer Kursiyer { get; set; }
    }
}
