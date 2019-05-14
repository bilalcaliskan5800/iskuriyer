namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SirketBilgileri")]
    public partial class SirketBilgileri
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string SektörAdi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KurulusYili { get; set; }

        public int? CalisanSayisi { get; set; }

        [StringLength(100)]
        public string WebSitesi { get; set; }

        [StringLength(350)]
        public string AcikAdres { get; set; }

        [StringLength(50)]
        public string CalismaSaatleri { get; set; }

        public bool? Sigorta { get; set; }

        public bool? Yemek { get; set; }

        public bool? Servis { get; set; }

        public int? SirketID { get; set; }

        public virtual Sirket Sirket { get; set; }
    }
}
