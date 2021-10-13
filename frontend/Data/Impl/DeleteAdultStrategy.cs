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

        public void Delete(Person person, Family family)
        {
            _familyService.RemoveAdultFromFamily(family, (Adult) person);
        }
    }
}