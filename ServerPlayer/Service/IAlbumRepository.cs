
using ServerPlayer.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerPlayer.Service
{
    /// <summary>
    /// Defines methods for interacting with the customers backend.
    /// </summary>
    public interface IAlbumRepository
    {
        /// <summary>
        /// Returns all Artists. 
        /// </summary>
        Task<IEnumerable<Album>> GetAsync();

        /// <summary>
        /// Returns all Artists with a data field matching the start of the given string. 
        /// </summary>
        Task<IEnumerable<Album>> GetAsync(string search);

        /// <summary>
        /// Returns the Artists with the given id. 
        /// </summary>
        Task<Album> GetAsync(int id);

        /// <summary>
        /// Adds a new customer if the customer does not exist, updates the 
        /// existing customer otherwise.
        /// </summary>
        //Task<Artist> UpsertAsync(Artist artist);

        ///// <summary>
        ///// Deletes a customer.
        ///// </summary>
        //Task DeleteAsync(Guid artistId);
    }
}