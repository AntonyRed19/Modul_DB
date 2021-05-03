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
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Song").HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("SongId");
            builder.Property(s => s.Title).IsRequired().HasColumnName("Title").HasMaxLength(50);
            builder.Property(s => s.Duration).IsRequired().HasColumnName("Duration").HasColumnType("time");
            builder.Property(s => s.RealesDate).IsRequired().HasColumnName("RealesDate").HasColumnType("datetime");
            builder.HasOne(s => s.Genre)
              .WithMany(s => s.Songs)
              .HasForeignKey(s => s.GenreId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
