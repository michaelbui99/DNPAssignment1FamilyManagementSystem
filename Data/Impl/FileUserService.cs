using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public class FileUserService : IUserService
    {
        public IList<User> Users { get; set; }
        private string _usersFile = "Users.json"; 
        
        public FileUserService()
        {
            if (!File.Exists(_usersFile))
            {
                Users = new List<User>();
                FileStream fileStream = File.Create(_usersFile);
                fileStream.Close();
            }
            else
            {
                string usersAsJson = File.ReadAllText(_usersFile);
                if (usersAsJson.Length == 0)
                {
                    Users = new List<User>();
                    return; 
                }
                Users = JsonSerializer.Deserialize<List<User>>(usersAsJson);
               //Debugging 
                Console.WriteLine("Users has been Deserialized");
                foreach (var user in Users)
                {
                    Console.WriteLine(user);
                }
            }
        }


        public void Create(User user)
        {
            foreach (var u in Users)
            {
                if (u.Username == user.Username)
                {
                    throw new Exception("User already exists"); 
                }
            }
            
            Users.Add(user);
            WriteUsersToFile();
        }

        public User Get(string username)
        {
            User userToReturn = Users.FirstOrDefault(u => u.Username == username);
            if (userToReturn is null)
            {
                throw new Exception("User not found"); 
            }

            return userToReturn; 
        }

        public User ValidateUser(string username, string password)
        {
            User userToValidate = Users.FirstOrDefault(u => u.Username == username);

            if (userToValidate is null)
            {
                throw new Exception("User not Found"); 
            }

            if (userToValidate.Password != password)
            {
                throw new Exception("Incorrect Password"); 
            }

            return userToValidate; 
        }

        private void WriteUsersToFile()
        {
            string usersAsJson = JsonSerializer.Serialize(Users);
            File.WriteAllText(_usersFile, usersAsJson);
        }
    }
}