using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProjectFmi.Repositories
{
    public interface IPerformerRepository
    {
        IEnumerable<Performer> GetAllPerformers { get; }
        Performer GetPerformerByName(string name);
        void AddPerformer(Performer performer);
    }
}
