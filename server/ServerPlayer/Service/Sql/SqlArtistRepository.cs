
using Microsoft.EntityFrameworkCore;
using ServerPlayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerPlayer.Service
{
    /// <summary>
    /// Contains methods for interacting with the products backend using 
    /// SQL via Entity Framework Core 2.0.
    /// </summary>
    public class SqlAlbumRepository : IAlbumRepository
    {
        private readonly MusicContext _db;

        public SqlAlbumRepository(MusicContext db)
        {
            _db = db; 
        }

        public async Task<IEnumerable<Album>> GetAsync()
        {
            return await _db.Albums
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Album> GetAsync(int id)
        {
            return await _db.Albums
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<Album>> GetAsync(string value)
        {
            return await _db.Albums.Where(product =>
                product.ArtistName.StartsWith(value)  )
            .AsNoTracking()
            .ToListAsync();
        }
    }
}
