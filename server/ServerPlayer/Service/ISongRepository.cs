
using ServerPlayer.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerPlayer.Service
{
    /// <summary>
    /// Defines methods for interacting with the products backend.
    /// </summary>
    public interface ISongRepository
    {
        /// <summary>
        /// Returns all song. 
        /// </summary>
        Task<IEnumerable<Song>> GetAsync();

        /// <summary>
        /// Returns the Song with the given Id. 
        /// </summary>
        Task<Song> GetAsync(Guid id);

        /// <summary>
        /// Returns all Songs with a data field matching the start of the given string. 
        /// </summary>
        Task<IEnumerable<Song>> GetAsync(string search);
        Task<IEnumerable<Song>> SearchAsync(string search);
    }
}
