using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Data.Impl
{
    public interface IDeleteStrategy
    {
        void Delete(Person person, Family family);
    }
}