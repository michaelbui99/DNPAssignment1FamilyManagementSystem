using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Persistence;

namespace FamilyManagementRestApi.Repositories.Impl
{
    public class FileUsersRepository : IUsersRepository
    {

        public IList<User> Users { get; set; }
        private const string UsersFile = "Users.json";

        public FileUsersRepository()
        {
            if (!File.Exists(UsersFile))
            {
                Users = new List<User>();
                FileStream fileStream = File.Create(UsersFile); 
                fileStream.Close();
               CreateGuestUser();
            }
            else
            {
                string usersAsJson = File.ReadAllText(UsersFile);
                if (usersAsJson.Length <= 0)
                {
                    Users = new List<User>();
                    return;
                }
                Users = JsonSerializer.Deserialize<List<User>>(usersAsJson);

                try
                {
                     GetUserAsync("Guest").Wait();
                }
                catch (KeyNotFoundException e)
                {
                   CreateGuestUser();
                }
                
            }
        }


        public async Task CreateUserAsync(User user)
        {
            if (user == null)
            {
                throw new NullReferenceException("Users must not be null");
            }

            if (UserExists(user.Username))
            {
                throw new ArgumentException("User already exists");
            }

            Users.Add(user);
            WriteUsersToFile();
        }

        public async Task RemoveUserAsync(User user)
        {
            if (user == null)
            {
                throw new NullReferenceException("User must not be null"); 
            }

            if (!UserExists(user.Username))
            {
                throw new KeyNotFoundException("No such user exists"); 
            }

            Users.Remove(user); 
            WriteUsersToFile();
        }

        public async Task<User> GetUserAsync(string username)
        {
            User existingUser = Users.FirstOrDefault(u => u.Username == username);
            if (existingUser == null)
            {
                throw new KeyNotFoundException("User not found");
            }

            return existingUser;
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {

            if (!UserExists(username))
            {
                throw new KeyNotFoundException("User not Found"); 
            }
            
            User userToValidate = await GetUserAsync(username);

            if (userToValidate.Password != password)
            {
                Console.WriteLine($"{this} {nameof(ValidateUserAsync)} threw exception");
                throw new ArgumentException("Incorrect Password"); 
            }

            return userToValidate; 
        }

        private bool UserExists(string username)
        {
            User existingUser = Users.FirstOrDefault(u => u.Username == username);
            if (existingUser == null)
            {
                return false; 
            }

            return true; 
        }
        private void WriteUsersToFile()
        {
            string usersAsJson = JsonSerializer.Serialize(Users); 
            File.WriteAllText(UsersFile, usersAsJson);
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