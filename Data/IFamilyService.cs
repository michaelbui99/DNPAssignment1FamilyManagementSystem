using System.Collections.Generic;
using Models;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public interface IFamilyService
    {
        IList<Family> GetFamilies();
        void CreateFamily(Family family);
        void DeleteFamily(string streetName, int houseNumber);
        Family Get(string streetName, int houseNumber); 
    }
}