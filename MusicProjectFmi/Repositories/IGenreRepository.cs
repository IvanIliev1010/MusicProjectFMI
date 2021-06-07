using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProjectFmi.Repositories
{
   public interface IGenreRepository
    {
        Genre  GetGenreById(int id);
        IEnumerable<Genre> GetAllGenres { get; }

    }
}
