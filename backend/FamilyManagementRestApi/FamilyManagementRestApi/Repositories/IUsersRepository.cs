using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Repositories
{
    public interface IUsersRepository
    {
        Task CreateUserAsync(User user);
        Task RemoveUserAsync(User user);
        Task<User> GetUserAsync(string username); 
        Task<User> ValidateUserAsync(string username, string password); 
    }
}