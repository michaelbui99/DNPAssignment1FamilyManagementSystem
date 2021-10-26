using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public interface IUserService
    {
        Task CreateAsync(User user);
        Task<User> GetAsync(string username);

        Task<User> ValidateUserAsync(string username, string password); 
    }
}