namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kursiyer")]
    public partial class Kursiyer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kursiyer()
        {
            Kursiyer_Adres = new HashSet<Kursiyer_Adres>();
            Kursiyer_Deneyim = new HashSet<Kursiyer_Deneyim>();
            Kursiyer_Egitim = new HashSet<Kursiyer_Egitim>();
            Kursiyer_Iletisim = new HashSet<Kursiyer_Iletisim>();
            Kursiyer_Referans = new HashSet<Kursiyer_Referans>();
            Kursiyer_YabanciDil = new HashSet<Kursiyer_YabanciDil>();
            Kursiyer_YazilimDil = new HashSet<Kursiyer_YazilimDil>();
            Kursiyer_Yetenek = new HashSet<Kursiyer_Yetenek>();
        }

        public int ID { get; set; }

        [StringLength(20)]
        public string Adi { get; set; }

        [StringLength(15)]
        public string Soyadi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }

        [StringLength(11)]
        public string TCKimlikNo { get; set; }

        [StringLength(10)]
        public string Sifre { get; set; }

        [StringLength(5)]
        public string Cinsiyet { get; set; }

        [StringLength(50)]
        public string AskerlikDurumu { get; set; }

        [StringLength(10)]
        public string SurucuBelgesi { get; set; }

        [StringLength(50)]
        public string Unvan { get; set; }

        [StringLength(150)]
        public string WebSayfasi { get; set; }

        public string ProfilFoto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursiyer_Adres> Kursiyer_Adres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursiyer_Deneyim> Kursiyer_Deneyim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursiyer_Egitim> Kursiyer_Egitim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursiyer_Iletisim> Kursiyer_Iletisim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursiyer_Referans> Kursiyer_Referans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursiyer_YabanciDil> Kursiyer_YabanciDil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursiyer_YazilimDil> Kursiyer_YazilimDil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursiyer_Yetenek> Kursiyer_Yetenek { get; set; }
    }
}
