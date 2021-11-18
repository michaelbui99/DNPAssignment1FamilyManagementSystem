using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Services
{
    public interface IFamiliesService
    {
        /// <summary>
        /// Returns a single family
        /// </summary>
        /// <param name="streetName">Street name of the family</param>
        /// <param name="houseNumber">House number of the family</param>
        /// <exception cref="ArgumentException">streetName is null</exception>
        /// <exception cref="ArgumentException">houseNumber is less than 0</exception>
        /// <exception cref="KeyNotFoundException">Family does not exist</exception>
        /// <returns>The family with given street name and house number</returns>
        Task<Family> GetFamilyAsync(string streetName, int houseNumber);

        /// <summary>
        /// Returns collection of all families
        /// </summary>
        /// <returns>All families as IEnumerable</returns>
        Task<IEnumerable<Family>> GetFamiliesAsync();

        /// <summary>
        /// Deletes an family
        /// </summary>
        /// <param name="streetName">the street name of the family that is to be deleted</param>
        /// <param name="houseNumber">the house number of the family that is to be deleted </param>
        /// <exception cref="ArgumentException">streetName is null</exception>
        /// <exception cref="ArgumentException">houseNumber is less than 0</exception>
        /// <exception cref="KeyNotFoundException">family does not exist</exception>
        /// <returns>the deleted family</returns>
        Task<Family> DeleteFamilyAsync(string streetName, int houseNumber);


        /// <summary>
        /// Creates a new family
        /// </summary>
        /// <param name="family">The family that is to be created</param>
        /// <exception cref="ArgumentException">family is null</exception>
        /// <exception cref="ArgumentException">family with same street number and house number already exists</exception>
        /// <returns>the created family</returns>
        Task<Family> CreateFamilyAsync(Family family);

        /// <summary>
        /// Checks if there exists an family with a given street name and house number 
        /// </summary>
        /// <param name="streetName">street name of the family</param>
        /// <param name="houseNumber">house number of the family</param>
        /// <exception cref="ArgumentException">streetName is null</exception>
        /// <exception cref="ArgumentException">houseNumber is less than 0</exception>
        /// <returns>true if family exists, else false</returns>
        bool FamilyExists(string streetName, int houseNumber);
    }
}