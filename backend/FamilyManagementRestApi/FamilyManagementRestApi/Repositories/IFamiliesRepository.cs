using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Repositories
{
    public interface IFamiliesRepository
    {
   
        Task<IEnumerable<Family>> GetFamiliesAsync();

     
        Task<Family> GetFamilyAsync(string streetName, int houseNumber);

       
        Task<Family> UpdateFamilyAsync(Family family);


        Task<Family> DeleteFamilyAsync(string streetName, int houseNumber);

      
        Task<Family> CreateFamilyAsync(Family family);


    
        bool FamilyExists(string streetName, int houseNumber);
    }
}