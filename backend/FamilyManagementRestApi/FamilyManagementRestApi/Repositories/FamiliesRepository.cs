using System.Collections.Generic;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Repositories
{
    public interface IFamiliesRepository
    {
        IEnumerable<Family> GetFamilies();
        Family GetFamily(string streetName, int houseNumber);
        void UpdateFamily(Family family);
        void DeleteFamily(string streetName, int houseNumber);
        void CreateFamily(Family family);
    }
}