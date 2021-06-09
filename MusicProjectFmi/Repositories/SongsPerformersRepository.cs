using Microsoft.EntityFrameworkCore;
using MusicProjectFmi.Data;
using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicProjectFmi.Repositories
{
    public class SongsPerformersRepository : ISongsPerformersRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public SongsPerformersRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Add(SongPerformer songPerformer)
        {
            _appDbContext.Entry(songPerformer).State = EntityState.Detached;
            _appDbContext.SongsPerformers.Add(songPerformer);
            _appDbContext.SaveChanges();
            _appDbContext.Entry(songPerformer).State = EntityState.Detached;
        }
        public ICollection<SongPerformer> GetSongPerformers(int songId) => _appDbContext.SongsPerformers.AsNoTracking()//.Include(x => x.Song).AsNoTracking()
                                                                                                        //.Include(x => x.Performer).AsNoTracking()
                                                                                                        .Where(x => x.SongId == songId)
                                                                                                        .ToList();
        public void Delete(SongPerformer songPerformer)
        {
         //   _appDbContext.Entry(songPerformer.Performer).State = EntityState.Detached;
           // _appDbContext.Entry(songPerformer.Song).State = EntityState.Detached;
            _appDbContext.Entry(songPerformer).State = EntityState.Deleted;
           // _appDbContext.SongsPerformers.Remove(songPerformer);

            _appDbContext.SaveChanges();
            _appDbContext.Entry(songPerformer).State = EntityState.Detached;
        }
     
    }

}
