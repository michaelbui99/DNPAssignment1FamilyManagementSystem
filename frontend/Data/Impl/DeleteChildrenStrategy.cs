using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Data.Impl
{
    public class DeleteChildrenStrategy : IDeleteStrategy
    {

        private IFamilyService _familyService;

        public DeleteChildrenStrategy(IFamilyService familyService)
        {
            _familyService = familyService;
        }

        public async Task DeleteAsync(Person person, Family family)
        {
            await _familyService.RemoveChildFromFamilyAsync(family, (Child) person);
        }
    }
}