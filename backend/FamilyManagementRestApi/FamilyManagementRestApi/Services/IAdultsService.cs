using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Services
{
    public interface IAdultsService
    {
        /// <summary>
        /// Returns a collection of all adults
        /// </summary>
        /// <returns>All adults</returns>
        Task<IEnumerable<Adult>> GetAdultsAsync();
        /// <summary>
        /// Returns a single adult. 
        /// </summary>
        /// <param name="id">id of the adult</param>
        /// <exception cref="KeyNotFoundException"> If no adult with id exist</exception>
        /// <returns>Adult with the given id</returns>
        Task<Adult> GetAdultAsync(int id);
        /// <summary>
        /// Adds an adult to a family
        /// </summary>
        /// <param name="family">The family that the adult is to be added to</param>
        /// <param name="adult">the Adult that is to be added</param>
        /// <exception cref="ArgumentException">Adult or family is null</exception>
        /// <exception cref="KeyNotFoundException">Family does not exist</exception>
        /// <returns>The added adult</returns>
        Task<Adult> AddAdultToFamilyAsync(Family family, Adult adult);
        /// <summary>
        /// Deletes an adult 
        /// </summary>
        /// <param name="id">the id the of adult that is to be deleted</param>
        /// <exception cref="ArgumentException">Id is less than 0</exception>
        /// <exception cref="KeyNotFoundException">Adult does not exist</exception>
        /// <returns>The deleted adult</returns>
        Task<Adult> DeleteAdultAsync(int id);
    }
}