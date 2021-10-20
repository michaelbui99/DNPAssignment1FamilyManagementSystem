using System.Collections.Generic;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Repositories
{
    public interface IUsersRepository
    {
        void CreateUser(User user);
        void RemoveUser(User user);
        User GetUser(string username); 
        User ValidateUser(string username, string password); 
    }
}