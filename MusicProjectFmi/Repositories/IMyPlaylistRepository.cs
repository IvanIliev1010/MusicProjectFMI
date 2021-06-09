using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProjectFmi.Repositories
{
public interface IMyPlaylistRepository
    {
        IEnumerable<int> GetAllSongIds { get; }
        IEnumerable<MyPlaylist> GetAllMyPlaylists { get; }
        bool CheckFromPlaylist(int Id);
        void Add(int songId);
        void Delete(MyPlaylist song);
    }
}
