using System.Collections.Generic;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public interface IFamilyStatisticsService
    {
        IDictionary<string, int> GetEyeColorDistribution();
        decimal GetAverageChildrenPerFamily();
        int GetTotalAmountOfFamilies();
        int GetTotalAmountOfAdults();
        int GetTotalAmountOfChildren();
        int GetTotalAmountOfPets();
        decimal GetAverageSalaryPerFamily();
    }
}