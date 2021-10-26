using System.Collections.Generic;
using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public interface IFamilyService
    {
        Task<IList<Family>> GetFamiliesAsync();
        Task CreateFamilyAsync(Family family);
        Task DeleteFamilyAsync(string streetName, int houseNumber);
        Task<Family> GetFamilyAsync(string streetName, int houseNumber);
        Task AddAdultToFamilyAsync(Family family, Adult adult);
        Task RemoveAdultFromFamilyAsync(Family family, Adult adult);
        Task RemoveChildFromFamilyAsync(Family family, Child child); 
    }
}