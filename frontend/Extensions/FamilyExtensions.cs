using DNPAssignment1FamilyManagementSystem.Dtos;
using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Extensions
{
    public static class FamilyExtensions
    {
        public static CreateFamilyDto AsDto(this Family family)
        {
            return new CreateFamilyDto()
            {
                HouseNumber = family.HouseNumber, StreetName = family.StreetName
            }; 
        }
    }
}