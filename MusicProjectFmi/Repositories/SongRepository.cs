using Microsoft.EntityFrameworkCore;
using MusicProjectFmi.Data;
using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicProjectFmi.Repositories
{
    public class SongRepository : ISongRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SongRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public IEnumerable<Song> GetAllSongs => _appDbContext.Songs.AsNoTracking().Include(x => x.Genre)
                                                                     .Include(x => x.Album)
                                                                     .Include(x =>x.SongPerformer).ThenInclude(x => x.Performer)
                                                                     .ToList();

 

        public Song GetSongById(int id) => _appDbContext.Songs.AsNoTracking().Include(x => x.Genre).AsNoTracking()
                                                              .Include(x => x.Album).AsNoTracking()
                                                              .Include(x => x.SongPerformer)//.ThenInclude(x => x.Performer).AsNoTracking()
                                                              .FirstOrDefault(x => x.Id == id);
        public void Add (Song song)
        {
            _appDbContext.Songs.Add(song);
            _appDbContext.SaveChanges();
            _appDbContext.Entry(song).State = Microsoft.EntityFrameworkCore.EntityState.Detached;

        }
        public void Update(Song song)
        {
           // var oldSong = _appDbContext.Songs.AsNoTracking().Single(x => x.Id == song.Id);
           // oldSong.AlbumId = song.AlbumId;
           // oldSong.GenreId = song.GenreId;
           // oldSong.Album = song.Album;
           // oldSong.Genre = song.Genre;
           // oldSong.Name = song.Name;
           // oldSong.Year = song.Year;
            _appDbContext.Entry(song).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            _appDbContext.Songs.Update(song);
           // _appDbContext.Entry(oldSong).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appDbContext.SaveChanges();
            _appDbContext.Entry(song).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
        public void Delete(int id)
        {
            var song = _appDbContext.Songs.Find(id);
            _appDbContext.Songs.Remove(song);
            _appDbContext.SaveChanges();
        }

        public Song GetSongByName(string name)
        {
            return _appDbContext.Songs.AsNoTracking().FirstOrDefault(s => s.Name==name);
        }
    }
}
