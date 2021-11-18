using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Repositories;

namespace FamilyManagementRestApi.Services.Impl
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            if (user == null)
            {
                throw new NullReferenceException("User cannot be null");
            }

            User existingUser = await _usersRepository.GetUserAsync(user.Username);
            if (existingUser != null)
            {
                Console.WriteLine($"Throw exception: User: {existingUser.Username} already exist");
                throw new ArgumentException("User already exists");
            }

            return await _usersRepository.CreateUserAsync(user); 
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            User userToValidate = await _usersRepository.GetUserAsync(username);
            if (userToValidate == null)
            {
                throw new KeyNotFoundException("User not found");
            }
            
            if (userToValidate.Password != password)
            {
                throw new ArgumentException("Incorrect Password"); 
            }

            return userToValidate; 
        }
        
    }
}