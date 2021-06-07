using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicProjectFmi.Data.Models
{
   public class Performer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<SongPerformer> SongPerformer { get; set; }
    }
}
