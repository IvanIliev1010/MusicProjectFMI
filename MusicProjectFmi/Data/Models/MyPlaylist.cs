using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicProjectFmi.Data.Models
{
  public  class MyPlaylist
    {
        [Required]
        public string Name { get; set; }

        public int SongId { get; set; }

        public Song Song { get; set; }
    }
}
