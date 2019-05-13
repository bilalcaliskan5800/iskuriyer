namespace iskuriyer.DataAccessLayer.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using iskuriyer.Entity;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Kursiyer> Kursiyer { get; set; }
        public virtual DbSet<Kursiyer_Adres> Kursiyer_Adres { get; set; }
        public virtual DbSet<Kursiyer_Deneyim> Kursiyer_Deneyim { get; set; }
        public virtual DbSet<Kursiyer_Egitim> Kursiyer_Egitim { get; set; }
        public virtual DbSet<Kursiyer_Iletisim> Kursiyer_Iletisim { get; set; }
        public virtual DbSet<Kursiyer_Referans> Kursiyer_Referans { get; set; }
        public virtual DbSet<Kursiyer_YabanciDil> Kursiyer_YabanciDil { get; set; }
        public virtual DbSet<Kursiyer_YazilimDil> Kursiyer_YazilimDil { get; set; }
        public virtual DbSet<Kursiyer_Yetenek> Kursiyer_Yetenek { get; set; }
        public virtual DbSet<Sirket> Sirket { get; set; }
        public virtual DbSet<SirketBilgileri> SirketBilgileri { get; set; }
        public virtual DbSet<SirketIlanlari> SirketIlanlari { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kursiyer>()
                .Property(e => e.TCKimlikNo)
                .IsFixedLength();

            modelBuilder.Entity<Kursiyer>()
                .Property(e => e.Cinsiyet)
                .IsFixedLength();

            modelBuilder.Entity<Kursiyer>()
                .Property(e => e.SurucuBelgesi)
                .IsFixedLength();

            modelBuilder.Entity<Kursiyer_Adres>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<Kursiyer_Iletisim>()
                .Property(e => e.TelefonNo)
                .IsFixedLength();

            modelBuilder.Entity<Kursiyer_Referans>()
                .Property(e => e.Telefon)
                .IsFixedLength();

            modelBuilder.Entity<Sirket>()
                .Property(e => e.Telefon)
                .IsFixedLength();
        }
    }
}
