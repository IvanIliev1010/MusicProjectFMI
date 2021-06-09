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
        public IEnumerable<MyPlaylist> GetAllMyPlaylists => _appDbContext.MyPlaylists.AsNoTracking().ToList();
        public void Add(int songId) 
        {
            MyPlaylist song = new MyPlaylist();
            song.SongId = songId;
            bool songIsNotAdded = _appDbContext.MyPlaylists.FirstOrDefault(s => s.SongId == songId) == null;
            if (songIsNotAdded)
            {
                _appDbContext.MyPlaylists.Add(song);
                _appDbContext.SaveChanges();
            }
            _appDbContext.Entry(song).State = EntityState.Detached;
        }
        //delete function
        public void Delete(MyPlaylist song)
        {
            _appDbContext.Entry(song).State = EntityState.Deleted;
            _appDbContext.SaveChanges();
            _appDbContext.Entry(song).State = EntityState.Detached;

        }
        //end of function



        public bool CheckFromPlaylist(int Id) => _appDbContext.MyPlaylists
               .AsNoTracking()
               .FirstOrDefault(x => x.SongId == Id) != null;
               
       
    }
}
