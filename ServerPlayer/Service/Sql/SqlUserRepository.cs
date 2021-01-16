using Microsoft.EntityFrameworkCore;
using ServerPlayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerPlayer.Service.Sql
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly MusicContext _db;

        public SqlUserRepository(MusicContext db)
        {
            _db = db;
        }
        public async Task<User> AuthenticateAsync(User user)
        {
            return await _db.Users.FirstOrDefaultAsync(u => 
                u.Name == user.Name && user.Password == user.Password);
        }

        public async Task<IEnumerable<Album>> GetAlbums(int id)
        {
            var res =( from UserAlbums userAlbums in _db.UserAlbums
                       where userAlbums.UserId == id
                       join Album alb in _db.Albums on 
                       userAlbums.AlbumId equals alb.ID into o
                       from alb in o
                      select new Album
                      {
                          ID = alb.ID,
                          Image = alb.Image,
                          ArtistName = alb.ArtistName,
                          Title = alb.Title,
                           Type = alb.Type,
                          YearOfPublication = (DateTime)alb.YearOfPublication
                      }).ToList();
            return res;
        }

        public async Task<bool> InserAsync(User user)
        {
            var existing = await _db.Users.FirstOrDefaultAsync(
                u => u.Name == user.Name && u.Password == user.Password);
            if (null == existing)
            {
                _db.Users.Add(user);
            }
            else
            {
                _db.Entry(existing).CurrentValues.SetValues(user);
            }
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
