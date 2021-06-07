using MusicProjectFmi.Data.Models;
using System.Collections.Generic;

namespace MusicProjectFmi.Repositories
{
    public interface ISongRepository
    {
        Song GetSongById(int id);
        Song GetSongByName(string name);
        IEnumerable<Song> GetAllSongs { get; }
        void Add(Song song);
        void Update(Song song);
        void Delete(int song);

    }
}