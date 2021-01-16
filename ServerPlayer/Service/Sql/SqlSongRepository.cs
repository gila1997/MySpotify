
using Microsoft.EntityFrameworkCore;
using ServerPlayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerPlayer.Service
{
    /// <summary>
    /// Contains methods for interacting with the customers backend using 
    /// SQL via Entity Framework Core 2.0.
    /// </summary>
    public class SqlSongRepository : ISongRepository
    {
        private readonly MusicContext _db; 

        public SqlSongRepository(MusicContext db)
        {
            _db = db; 
        }

        public async Task<IEnumerable<Song>> GetAsync()
        {
            return await _db.Songs
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Song> GetAsync(Guid id)
        {
            return await _db.Songs
                .AsNoTracking()
                .FirstOrDefaultAsync(customer => customer.ID == id);
        }

        public async Task<IEnumerable<Song>> GetAsync(string value)
        {
            string[] parameters = value.Split(' ');
            return await _db.Songs
                .Where(customer =>
                    parameters.Any(parameter =>
                        customer.Name.StartsWith(parameter)))
                
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Song> UpsertAsync(Song song)
        {
            var current = await _db.Songs.FirstOrDefaultAsync(_customer => _customer.ID == song.ID);
            if (null == current)
            {
                _db.Songs.Add(song);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(song);
            }
            await _db.SaveChangesAsync();
            return song;
        }

        public async Task DeleteAsync(Guid id)
        {
            var customer = await _db.Songs.FirstOrDefaultAsync(_customer => _customer.ID == id);
         
        }

        public async Task<IEnumerable<Song>> SearchAsync(string search)
        {
            return await 
                _db.Songs.Where(s => s.Name.Contains(search)).ToListAsync();
        }
    }
}
