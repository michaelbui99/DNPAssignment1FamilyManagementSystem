using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Data.Impl
{
    public interface IDeleteStrategy
    {
        Task DeleteAsync(Person person, Family family);
    }
}