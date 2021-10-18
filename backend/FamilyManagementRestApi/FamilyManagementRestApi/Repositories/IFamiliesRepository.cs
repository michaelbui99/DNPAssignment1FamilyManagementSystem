using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Repositories
{
    public interface IFamiliesRepository
    {
        /// <summary>
        /// Gets a Enumerable of all Families currently in the system. 
        /// </summary>
        /// <returns>Enumerable of all families as task</returns>
        Task<IEnumerable<Family>> GetFamiliesAsync();

        /// <summary>
        /// Gets a specific family uniquely identified by their streetName and houseNumber
        /// </summary>
        /// <param name="streetName">Street name of the family</param>
        /// <param name="houseNumber">House name of the family</param>
        /// <exception cref="KeyNotFoundException">Thrown if no family with the given streetName and houseNumber exists</exception>
        /// <exception cref="ArgumentException">Thrown if houseNumber is less that 0 of if streetName is null/empty string</exception>
        /// <returns>a Family as a task</returns>
        Task<Family> GetFamilyAsync(string streetName, int houseNumber);

        /// <summary>
        /// Replaces a family if the family exists. 
        /// </summary>
        /// <param name="family">the family that is to be replaced</param>
        /// <exception cref="KeyNotFoundException">Thrown if no family with the given streetName and houseNumber exists</exception>
        /// <exception cref="NullReferenceException">Thrown if family is null</exception>
        /// <returns>The replaced family as a task</returns>
        Task<Family> UpdateFamilyAsync(Family family);

        /// <summary>
        /// Deletes a Family
        /// </summary>
        /// <param name="streetName">Street name of the family</param>
        /// <param name="houseNumber">House number of the family</param>
        /// <exception cref="KeyNotFoundException">Thrown if no family with the given streetName and houseNumber exists</exception>
        /// <exception cref="NullReferenceException">Thrown if Family is null</exception>
        /// <exception cref="ArgumentException">Thrown if houseNumber is less that 0 of if streetName is null/empty string</exception>
        /// <returns>The deleted family as a task</returns>
        Task<Family> DeleteFamilyAsync(string streetName, int houseNumber);

        /// <summary>
        /// Creates a new Family
        /// </summary>
        /// <param name="family">The family to be created</param>
        /// <exception cref="ArgumentException">Thrown if the family already exists</exception>
        /// <returns>The newly created Family</returns>
        Task<Family> CreateFamilyAsync(Family family);


        /// <summary>
        /// Checks if an Family exists. 
        /// </summary>
        /// <param name="streetName">Street name of the family</param>
        /// <param name="houseNumber">House number of the family</param>
        /// <exception cref="ArgumentException">Thrown if houseNumber is less that 0 of if streetName is null/empty string</exception>
        /// <returns>True if family with given streetName and houseNumber exists. False if family does not exist.</returns>
        bool FamilyExists(string streetName, int houseNumber);
    }
}