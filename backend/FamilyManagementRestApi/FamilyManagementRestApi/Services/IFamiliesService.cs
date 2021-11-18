using System.Threading.Tasks;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Services
{
    public interface IFamiliesService
    {
        Task<Family> GetFamilyAsync(string streetName, int houseNumber); 
    }
}