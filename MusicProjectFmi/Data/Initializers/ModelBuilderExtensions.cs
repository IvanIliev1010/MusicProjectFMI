using Microsoft.EntityFrameworkCore;
using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProjectFmi.Data.Initializers
{
  public static  class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre {Id=1,Name="Pop",Description="Popular music" },
                new Genre { Id = 2, Name = "Rock", Description = "Very emotional music" },
                 new Genre { Id = 3, Name = "Chalga", Description = "Very cheap music" }


                );

            modelBuilder.Entity<Performer>().HasData(
                new Performer {Id=1,Name="Веселин Маринов" },
                new Performer {Id=2,Name="Elvis Presley" },
                new Performer {Id= 3, Name= "Ad/Dc" },
                new Performer {Id= 4, Name= "D2" },
                new Performer {Id= 5, Name= "Преслава" },
                new Performer {Id= 6, Name= "null" }//id=9



                );
            modelBuilder.Entity<Album>().HasData(
               new Album { Id=1, Name="Elv1s",Year=2002, PerformerId=2 },
               new Album { Id=2,Name="Back in Black",Year=1982, PerformerId=3},
               new Album { Id=3, Name="Ледено момиче",Year=2000, PerformerId=4},
               new Album { Id=4, Name="Дяволско желание",Year=2000, PerformerId=5},
               new Album { Id=5, Name="null",Year=0, PerformerId=6}// id=10

               );
            modelBuilder.Entity<Song>().HasData(
               new Song {Id=1,Name="Ледено Момиче",Year=2000,GenreId=1,AlbumId=3 },
               new Song {Id=2,Name="Две следи",Year=2000,GenreId=1,AlbumId=3 },
               new Song {Id=3,Name="Не мога да спра да те обичам",Year=2000,GenreId=1,AlbumId=3 },
               new Song {Id=4,Name="Hound Dog",Year=1956,GenreId=2,AlbumId=1 },
               new Song {Id=5,Name="Heartbreak Hotel",Year=1968,GenreId=2,AlbumId=1 },
               new Song {Id=6,Name="Dont't be Cruel",Year=1965,GenreId=2,AlbumId=1 },
               new Song {Id=7,Name="Back in Black",Year=1980,GenreId=2,AlbumId=2 },
               new Song {Id=8,Name="Shoot to thrill",Year=1981,GenreId=2,AlbumId=2 },
               new Song {Id=9,Name="Hells Bells",Year=1982,GenreId=2,AlbumId=2 },
               new Song {Id=10,Name="Финални думи", Year=2003,GenreId=3,AlbumId=4},
               new Song {Id=11,Name="Нямам право", Year=2004,GenreId=3,AlbumId=4},
               new Song {Id=12,Name="Дяволско желание", Year=2004,GenreId=3,AlbumId=4}

               );
            modelBuilder.Entity<SongPerformer>().HasData(
               new SongPerformer {SongId=1,PerformerId=4 },
               new SongPerformer {SongId=2,PerformerId=4 },
               new SongPerformer {SongId=3,PerformerId=4 },
               new SongPerformer {SongId=4,PerformerId=2 },
               new SongPerformer {SongId=5,PerformerId=2 },
               new SongPerformer {SongId=6,PerformerId=2 },
               new SongPerformer {SongId=7,PerformerId=3 },
               new SongPerformer {SongId=8,PerformerId=3 },
               new SongPerformer {SongId=9,PerformerId=3 },
               new SongPerformer {SongId=10,PerformerId=5 },
               new SongPerformer {SongId=11,PerformerId=5 },
               new SongPerformer {SongId=12,PerformerId=5 }

    

               );
           
        }
    }
}
