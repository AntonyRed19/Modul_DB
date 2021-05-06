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
    public class SongandArtistConfiguration : IEntityTypeConfiguration<SongandArtist>
    {
        public void Configure(EntityTypeBuilder<SongandArtist> builder)
        {
            builder.ToTable("SongArtist").HasKey(g => g.Id);
            builder.Property(g => g.Id).HasColumnName("Id");
            builder.HasOne(s => s.Song)
              .WithMany(s => s.SongArtists)
              .HasForeignKey(s => s.SongId)
              .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.Artist)
              .WithMany(s => s.SongArtists)
              .HasForeignKey(s => s.ArtistId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
