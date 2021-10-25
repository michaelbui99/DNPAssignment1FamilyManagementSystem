using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Repositories
{
    public interface IAdultsRepository
    {

        Task<IEnumerable<Adult>> GetAdultsAsync();
        Task<Adult> GetAdultAsync(int id); 

        /// <summary>
        /// Adds an adult to a family. 
        /// </summary>
        /// <param name="family">The family where the adult is to be added</param>
        /// <param name="adult">The adult that is to be added</param>
        /// <exception cref="KeyNotFoundException">Thrown if the family doesn't exist</exception>
        /// <exception cref="NullReferenceException">Thrown if Family or Adult is null</exception>
        /// <returns>The new Adult as a task</returns>
        Task<Adult> AddAdultToFamilyAsync(Family family, Adult adult);

        Task<Adult> RemoveAdultAsync(int adultId); 
    }
}