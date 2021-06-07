using Microsoft.EntityFrameworkCore;
using MusicProjectFmi.Data;
using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicProjectFmi.Repositories
{
   public class MyPlaylistRepository : IMyPlaylistRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public MyPlaylistRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<int> GetAllSongIds => _appDbContext.MyPlaylists.Select(x => x.SongId).ToList();

        public bool CheckFromPlaylist(int Id) => _appDbContext.MyPlaylists
               .AsNoTracking()
               .FirstOrDefault(x => x.SongId == Id) != null;
               
       
    }
}
