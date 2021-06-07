using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicProjectFmi.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Year { get; set; }
        public int GenreId {get; set;}
        public Genre Genre { get; set; }
        public int? AlbumId { get; set; }
        public Album Album { get; set; }
        public ICollection<SongPerformer> SongPerformer { get; set; }
   
    }
}