using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Task.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final_Task.EntityConfigurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("ArtistId");
            builder.Property(a => a.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
            builder.Property(a => a.DateofBirth).IsRequired().HasColumnName("DateofBirth").HasColumnType("datetime");
            builder.Property(a => a.Phone).IsRequired().HasColumnName("Phone").HasMaxLength(13);
            builder.Property(a => a.InstagramUrl).IsRequired().HasColumnName("InstagramUrl").HasMaxLength(50);
            builder.HasMany(a => a.Songs)
               .WithMany(a => a.Artists)
               .UsingEntity<Dictionary<string, object>>(
                   "Supply",
                   j => j
                       .HasOne<Song>()
                       .WithMany()
                       .HasForeignKey("ProductId"),
                   j => j
                       .HasOne<Artist>()
                       .WithMany()
                       .HasForeignKey("CompanyId"));
        }
    }
}
