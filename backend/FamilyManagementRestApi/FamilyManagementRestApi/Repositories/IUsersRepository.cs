using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Repositories
{
    public interface IUsersRepository
    {
        Task<User> CreateUserAsync(User user);
        Task RemoveUserAsync(User user);
        Task<User> GetUserAsync(string username); 
    }
}