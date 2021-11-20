using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.Services
{
    public interface IUsersService
    {
        
        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="user">The user to be created</param>
        /// <exception cref="NullReferenceException">user is null</exception>
        /// <exception cref="ArgumentException">user with username already exists</exception>
        /// <returns>the created user</returns>
        Task<User> CreateUserAsync(User user);

        /// <summary>
        /// Validates the user's credentials
        /// </summary>
        /// <param name="username">username of the user</param>
        /// <param name="password">password of the user</param>
        /// <exception cref="KeyNotFoundException">User does not exist</exception>
        /// <exception cref="ArgumentException">Password is incorrect</exception>
        /// <returns>The validated user</returns>
        Task<User> ValidateUserAsync(string username, string password); 

    }
}