using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProjectFmi.Repositories
{
public interface IMyPlaylistRepository
    {
        IEnumerable<int> GetAllSongIds { get; }
        bool CheckFromPlaylist(int Id);
    }
}
