using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LokaLBeer.Models.Mapping
{
    public class iletisimMap : EntityTypeConfiguration<iletisim>
    {
        public iletisimMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.il)
                .HasMaxLength(50);

            this.Property(t => t.ilce)
                .HasMaxLength(50);

            this.Property(t => t.telefon)
                .HasMaxLength(50);

            this.Property(t => t.adres)
                .HasMaxLength(50);

            this.Property(t => t.mail)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("iletisim");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.il).HasColumnName("il");
            this.Property(t => t.ilce).HasColumnName("ilce");
            this.Property(t => t.telefon).HasColumnName("telefon");
            this.Property(t => t.adres).HasColumnName("adres");
            this.Property(t => t.mail).HasColumnName("mail");
        }
    }
}
