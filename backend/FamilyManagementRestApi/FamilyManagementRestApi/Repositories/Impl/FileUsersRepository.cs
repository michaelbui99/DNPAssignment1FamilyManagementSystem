using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Persistence;

namespace FamilyManagementRestApi.Repositories.Impl
{
    public class FileUsersRepository : IUsersRepository
    {

        public IList<User> Users { get; set; }
        private const string _usersFile = "Users.json";

        public FileUsersRepository()
        {
            if (!File.Exists(_usersFile))
            {
                Users = new List<User>();
                FileStream fileStream = File.Create(_usersFile); 
                fileStream.Close();
               CreateGuestUser();
            }
            else
            {
                string usersAsJson = File.ReadAllText(_usersFile);
                if (usersAsJson.Length <= 0)
                {
                    Users = new List<User>();
                    return;
                }
                Users = JsonSerializer.Deserialize<List<User>>(usersAsJson);

                try
                {
                    GetUser("Guest");
                }
                catch (KeyNotFoundException e)
                {
                   CreateGuestUser();
                }
                
            }
        }


        public void CreateUser(User user)
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

        public void RemoveUser(User user)
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

        public User GetUser(string username)
        {
            User existingUser = Users.FirstOrDefault(u => u.Username == username);
            if (existingUser == null)
            {
                throw new KeyNotFoundException("User not found");
            }

            return existingUser;
        }

        public User ValidateUser(string username, string password)
        {

            if (!UserExists(username))
            {
                throw new Exception("User not Found"); 
            }
            
            User userToValidate = GetUser(username);

            if (userToValidate.Password != password)
            {
                throw new Exception("Incorrect Password"); 
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
            File.WriteAllText(_usersFile, usersAsJson);
        }

        private void CreateGuestUser()
        {
            User guestUser = new User()
            {
                Username = "Guest", Password = "Guest", Role = "Guest"
            }; 
            CreateUser(guestUser);
        }
    }
}