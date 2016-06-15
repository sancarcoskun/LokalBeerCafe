using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LokaLBeer.Models.Mapping
{
    public class kullanici_iletisim_mesajMap : EntityTypeConfiguration<kullanici_iletisim_mesaj>
    {
        public kullanici_iletisim_mesajMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.gsm)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("kullanici_iletisim_mesaj");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.gsm).HasColumnName("gsm");
            this.Property(t => t.mesaj).HasColumnName("mesaj");
        }
    }
}
