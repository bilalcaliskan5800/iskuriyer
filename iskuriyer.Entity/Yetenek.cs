namespace iskuriyer.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yetenek")]
    public partial class Yetenek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yetenek()
        {
            Kursiyer_Yetenek = new HashSet<Kursiyer_Yetenek>();
        }

        public int ID { get; set; }

        [StringLength(30)]
        public string Adi { get; set; }

        [StringLength(30)]
        public string Tipi { get; set; }

        [StringLength(6)]
        public string Derece { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kursiyer_Yetenek> Kursiyer_Yetenek { get; set; }
    }
}
