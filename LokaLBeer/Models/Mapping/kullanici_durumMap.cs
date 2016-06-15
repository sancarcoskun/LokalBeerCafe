using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LokaLBeer.Models.Mapping
{
    public class kullanici_durumMap : EntityTypeConfiguration<kullanici_durum>
    {
        public kullanici_durumMap()
        {
            // Primary Key
            this.HasKey(t => t.kullanici_durum_id);

            // Properties
            this.Property(t => t.ip)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("kullanici_durum");
            this.Property(t => t.kullanici_durum_id).HasColumnName("kullanici_durum_id");
            this.Property(t => t.kullanici_id).HasColumnName("kullanici_id");
            this.Property(t => t.ip).HasColumnName("ip");
            this.Property(t => t.giris_tarihi).HasColumnName("giris_tarihi");
            this.Property(t => t.cikis_tarihi).HasColumnName("cikis_tarihi");

            // Relationships
            this.HasRequired(t => t.kullanici)
                .WithMany(t => t.kullanici_durum)
                .HasForeignKey(d => d.kullanici_id);

        }
    }
}
