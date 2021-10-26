using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Models;


namespace DNPAssignment1FamilyManagementSystem.Data.Impl
{
    public class DeleteAdultStrategy : IDeleteStrategy
    {

        private IFamilyService _familyService;

        public DeleteAdultStrategy(IFamilyService familyService)
        {
            _familyService = familyService;
        }

        public async Task DeleteAsync(Person person, Family family)
        {
            await _familyService.RemoveAdultFromFamilyAsync(family, (Adult) person);
        }
    }
}