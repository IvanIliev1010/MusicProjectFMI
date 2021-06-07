using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProjectFmi.Data.EntityTypeConfiguration
{
    class SongsTypeConfiguration : IEntityTypeConfiguration <SongPerformer>
    {
        public void Configure(EntityTypeBuilder<SongPerformer> builder)
        {
            builder.HasKey(sp => new { sp.PerformerId, sp.SongId }); //anonimna funciaq lambda sintaksis
            builder.HasOne(sp => sp.Song)
                .WithMany(t => t.SongPerformer)
                .HasForeignKey(sp => sp.SongId);

            builder.HasOne(sp => sp.Performer)
                .WithMany(t => t.SongPerformer)
                .HasForeignKey(sp => sp.PerformerId);
                

        }
    }
}
