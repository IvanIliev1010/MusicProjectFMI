using Microsoft.EntityFrameworkCore;
using MusicProjectFmi.Data;
using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MusicProjectFmi.Repositories
{
    public class PerformerRepository : IPerformerRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public PerformerRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Performer> GetAllPerformers => _appDbContext.Performers.AsNoTracking().ToList();

        public Performer GetPerformerByName(string name) => _appDbContext.Performers.AsNoTracking()
               .Include(p => p.SongPerformer)
               .AsNoTracking()
               .SingleOrDefault(s => s.Name == name);

       public void AddPerformer(Performer performer)
        {
            _appDbContext.Performers.Add(performer);
            _appDbContext.SaveChanges();
            _appDbContext.Entry<Performer>(performer).State = EntityState.Detached;// stops tracking the object after entering database
        }
    }
    
}
