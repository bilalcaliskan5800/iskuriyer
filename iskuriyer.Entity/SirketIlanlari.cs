namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SirketIlanlari")]
    public partial class SirketIlanlari
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Baslik { get; set; }

        [StringLength(50)]
        public string Lokasyon { get; set; }

        [StringLength(50)]
        public string Pozisyon { get; set; }

        [StringLength(10)]
        public string Tecrübe { get; set; }

        public string Aciklama { get; set; }

        public string Yetenekler { get; set; }

        public int? SirketID { get; set; }

        public virtual Sirket Sirket { get; set; }
    }
}
