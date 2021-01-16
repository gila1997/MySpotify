using ServerPlayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ServerPlayer.Service
{
    public interface IMusicRepository
    {

        IAlbumRepository Albums { get; }

        ISongRepository Songs { get; }
        IUserRepository Users { get; }
    }
}
