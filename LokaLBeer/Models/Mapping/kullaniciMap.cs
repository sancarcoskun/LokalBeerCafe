using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LokaLBeer.Models.Mapping
{
    public class kullaniciMap : EntityTypeConfiguration<kullanici>
    {
        public kullaniciMap()
        {
            // Primary Key
            this.HasKey(t => t.kullanici_id);

            // Properties
            this.Property(t => t.ad)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.soyad)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.kullanici_adi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.sifre)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("kullanici");
            this.Property(t => t.kullanici_id).HasColumnName("kullanici_id");
            this.Property(t => t.ad).HasColumnName("ad");
            this.Property(t => t.soyad).HasColumnName("soyad");
            this.Property(t => t.kullanici_adi).HasColumnName("kullanici_adi");
            this.Property(t => t.sifre).HasColumnName("sifre");
            this.Property(t => t.admin).HasColumnName("admin");
            this.Property(t => t.aktif).HasColumnName("aktif");
        }
    }
}
