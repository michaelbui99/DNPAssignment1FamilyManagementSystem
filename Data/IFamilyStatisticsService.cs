using System.Collections.Generic;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public interface IFamilyStatisticsService
    {
        IDictionary<string, int> GetEyeColorDistribution();
    }
}