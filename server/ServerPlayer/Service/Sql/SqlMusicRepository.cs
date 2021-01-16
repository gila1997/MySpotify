
using Microsoft.EntityFrameworkCore;
using ServerPlayer.Service.Sql;

namespace ServerPlayer.Service
{
    /// <summary>
    /// Contains methods for interacting with the app backend using 
    /// SQL via Entity Framework Core 2.0. 
    /// </summary>
    public class SqlMusicRepository : IMusicRepository
    {
        private readonly DbContextOptions<MusicContext> _dbOptions; 

        public SqlMusicRepository(DbContextOptionsBuilder<MusicContext> 
            dbOptionsBuilder)
        {
            _dbOptions = dbOptionsBuilder.Options;
            using (var db = new MusicContext(_dbOptions))
            {
                db.Database.EnsureCreated();
                
            }
        }
     
        public IAlbumRepository Albums => new SqlAlbumRepository(
            new MusicContext(_dbOptions));
        public ISongRepository Songs => new SqlSongRepository(
            new MusicContext(_dbOptions));

        public IUserRepository Users => new SqlUserRepository(
          new MusicContext(_dbOptions));
    }
}
