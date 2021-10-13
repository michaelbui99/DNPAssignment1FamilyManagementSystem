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

        public void Delete(Person person, Family family)
        {
            _familyService.RemoveChildFromFamily(family, (Child) person);
        }
    }
}