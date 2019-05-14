namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sirket")]
    public partial class Sirket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sirket()
        {
            SirketBilgileri = new HashSet<SirketBilgileri>();
            SirketIlanlari = new HashSet<SirketIlanlari>();
        }

        public int ID { get; set; }

        [StringLength(30)]
        public string SirketAdi { get; set; }

        [StringLength(50)]
        public string YetkiliAdiSoyadi { get; set; }

        [StringLength(11)]
        public string Telefon { get; set; }

        [StringLength(150)]
        public string EPosta { get; set; }

        [StringLength(20)]
        public string Il { get; set; }

        [StringLength(20)]
        public string Ilce { get; set; }

        [StringLength(20)]
        public string VergiDairesiIli { get; set; }

        [StringLength(50)]
        public string VergiDairesi { get; set; }

        [StringLength(50)]
        public string VergiNo { get; set; }

        [StringLength(15)]
        public string KullaniciAdi { get; set; }

        [StringLength(10)]
        public string Sifre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SirketBilgileri> SirketBilgileri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SirketIlanlari> SirketIlanlari { get; set; }
    }
}
