using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public interface IFamilyStatisticsService
    {
        Task<IDictionary<string, int>> GetEyeColorDistributionAsync();
        Task<IDictionary<string, decimal>> GetSalaryDistributionAsync(); 
        Task<decimal> GetAverageChildrenPerFamilyAsync();
        Task<int> GetTotalAmountOfFamiliesAsync();
        Task<int> GetTotalAmountOfAdultsAsync();
        Task<int> GetTotalAmountOfChildrenAsync();
        Task<int> GetTotalAmountOfPetsAsync();
        Task<decimal> GetAverageSalaryPerFamilyAsync();
    }
}