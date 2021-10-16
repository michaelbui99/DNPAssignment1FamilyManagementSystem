using System.Collections.Generic;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetUsers();
        void CreateUser(User user);
        void RemoveUser(User user);
        User ValidateUser(string username, string password); 
    }
}