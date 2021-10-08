using System.Collections.Generic;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public interface IFamilyStatisticsService
    {
        IDictionary<string, int> GetEyeColorDistribution();
        IDictionary<string, decimal> GetSalaryDistribution(); 
        decimal GetAverageChildrenPerFamily();
        int GetTotalAmountOfFamilies();
        int GetTotalAmountOfAdults();
        int GetTotalAmountOfChildren();
        int GetTotalAmountOfPets();
        decimal GetAverageSalaryPerFamily();
    }
}