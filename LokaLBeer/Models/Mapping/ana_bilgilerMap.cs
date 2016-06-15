using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LokaLBeer.Models.Mapping
{
    public class ana_bilgilerMap : EntityTypeConfiguration<ana_bilgiler>
    {
        public ana_bilgilerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.baslik)
                .HasMaxLength(50);

            this.Property(t => t.title)
                .HasMaxLength(50);

            this.Property(t => t.metatag)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ana_bilgiler");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.baslik).HasColumnName("baslik");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.metatag).HasColumnName("metatag");
            this.Property(t => t.story).HasColumnName("story");
        }
    }
}
