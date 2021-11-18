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
        
        Task<Adult> AddAdultToFamilyAsync(Family family, Adult adult);

        Task<Adult> RemoveAdultAsync(int adultId); 
    }
}