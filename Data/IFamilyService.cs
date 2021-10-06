using System.Collections.Generic;
using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public interface IFamilyService
    {
        IList<Family> GetFamilies();
        void CreateFamily(Family family);
        void DeleteFamily(string streetName, int houseNumber);
        Family GetFamily(string streetName, int houseNumber);
        void AddAdultToFamily(Family family, Adult adult);
        void RemoveAdultFromFamily(Family family, Adult adult); 
    }
}