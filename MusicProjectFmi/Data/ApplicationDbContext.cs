using Microsoft.EntityFrameworkCore;
using System;
using MusicProjectFmi.Data.Models;
using MusicProjectFmi.Data.Initializers;

namespace MusicProjectFmi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() {}
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Performer> Performers{ get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet <MyPlaylist> MyPlaylists { get; set; }
        public DbSet<SongPerformer> SongsPerformers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DESKTOP-N9LJF86\MSSQLSERVER01
            optionsBuilder.EnableSensitiveDataLogging();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-N9LJF86\\MSSQLSERVER01; Database= MusicDb; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);                                     // go trough base and execute OnModelCreating 
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly); //execute ApplyConfigurationsFromAssembly
            modelBuilder.Entity<MyPlaylist>().HasNoKey();
            modelBuilder.Seed();

        }

    }
}
