using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProjectFmi.Repositories
{
    public interface ISongsPerformersRepository
    {
        void Add(SongPerformer songPerformer);
        ICollection<SongPerformer> GetSongPerformers(int songId);
        void Delete(SongPerformer songPerformer);
    }
}
