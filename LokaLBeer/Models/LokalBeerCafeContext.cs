using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using LokaLBeer.Models.Mapping;

namespace LokaLBeer.Models
{
    public partial class LokalBeerCafeContext : DbContext
    {
        static LokalBeerCafeContext()
        {
            Database.SetInitializer<LokalBeerCafeContext>(null);
        }

        public LokalBeerCafeContext()
            : base("Name=LokalBeerCafeContext")
        {
        }

        public DbSet<ana_bilgiler> ana_bilgiler { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<kullanici> kullanicis { get; set; }
        public DbSet<kullanici_durum> kullanici_durum { get; set; }
        public DbSet<kullanici_iletisim_mesaj> kullanici_iletisim_mesaj { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ana_bilgilerMap());
            modelBuilder.Configurations.Add(new iletisimMap());
            modelBuilder.Configurations.Add(new kullaniciMap());
            modelBuilder.Configurations.Add(new kullanici_durumMap());
            modelBuilder.Configurations.Add(new kullanici_iletisim_mesajMap());
        }
    }
}
