using Microsoft.EntityFrameworkCore;
using MusicProjectFmi.Data;
using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicProjectFmi.Repositories
{
   public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public GenreRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Genre> GetAllGenres => _appDbContext.Genres.AsNoTracking()
            .Include( x => x.Songs)
            .ToList();

      

        public Genre GetGenreById(int id) => _appDbContext.Genres
            .AsNoTracking()
            .SingleOrDefault(x => x.Id == id);
            

    }
}
