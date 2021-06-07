using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProjectFmi.Data.Models
{
     public class SongPerformer
    {
        public int SongId { get; set; }
        public int PerformerId { get; set; }
        public Song Song { get; set; }
        public Performer Performer { get; set; }
    }
}
