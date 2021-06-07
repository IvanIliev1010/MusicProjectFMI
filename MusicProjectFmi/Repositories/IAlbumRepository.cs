using MusicProjectFmi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProjectFmi.Repositories
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAllAlbums { get; }
        Album GetAlbumByName(string name);
        void AddAlbum(Album album);
    }
}
