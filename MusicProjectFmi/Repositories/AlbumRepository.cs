using Microsoft.EntityFrameworkCore;
using MusicProjectFmi.Data;
using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicProjectFmi.Repositories
{
     public class AlbumRepository : IAlbumRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public AlbumRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Album> GetAllAlbums => _appDbContext.Albums.AsNoTracking().ToList();

        public Album GetAlbumByName(string name) => _appDbContext.Albums
               .AsNoTracking()
               .FirstOrDefault(x => x.Name == name);
        public void AddAlbum(Album album)
        {
            _appDbContext.Albums.Add(album);
            _appDbContext.SaveChanges();
            _appDbContext.Entry<Album>(album).State = EntityState.Detached;// stops tracking the object after entering database
        }
    }
}
