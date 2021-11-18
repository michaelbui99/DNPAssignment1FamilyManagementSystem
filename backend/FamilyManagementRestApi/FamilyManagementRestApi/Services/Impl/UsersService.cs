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

            var guestUser = _usersRepository.GetUserAsync("Guest").Result;
            if (guestUser == null)
            {
                CreateGuestUser();
            }
        }

        public async Task<User> CreateUserAsync(User user)
        {
            if (user == null)
            {
                throw new NullReferenceException("User cannot be null");
            }

            User existingUser = await _usersRepository.GetUserAsync(user.Username);
            if (user != null)
            {
                throw new ArgumentException("User already exists");
            }

            return await _usersRepository.CreateUserAsync(user); 
        }

        public async Task<User> ValidateUserASync(string username, string password)
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

        private async void CreateGuestUser()
        {
            User guestUser = new User()
            {
                Username = "Guest", Password = "Guest123", Role = "Guest"
            };
            Console.WriteLine($"{this} creating user...");
            await CreateUserAsync(guestUser);
        }
    }
}