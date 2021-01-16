using ServerPlayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerPlayer.Service
{
    public interface IUserRepository
    {
        Task<bool> InserAsync(User user);
        Task<User> AuthenticateAsync(User user);
        Task<IEnumerable<Album>> GetAlbums(int id);

    }
}
