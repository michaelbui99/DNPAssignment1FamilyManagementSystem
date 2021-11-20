using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Models;
using DNPAssignment1FamilyManagementSystem.Models.Util;

namespace DNPAssignment1FamilyManagementSystem.Data.Impl
{
    public class WebUserService : IUserService
    {
        private const string RootUrl = "https://localhost:5001/api";

        public async Task CreateAsync(User user)
        {
            using HttpClient client = new HttpClient();
            string userAsJson = JsonSerializer.Serialize(user);
            StringContent payload = new StringContent(userAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync($"{RootUrl}/Users", payload);
            if (!responseMessage.IsSuccessStatusCode)
            {
                if (responseMessage.StatusCode == HttpStatusCode.Conflict)
                {
                    throw new ArgumentException("User Already exists");
                }

                throw new Exception(await responseMessage.Content.ReadAsStringAsync());
            }
        }

        public Task<User> GetAsync(string username)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            using HttpClient client = new HttpClient();
            User userToValidate = null;
            try
            {
                userToValidate = new User() {Username = username, Password = password};
            }
            catch (Exception e)
            {
                Console.WriteLine($"{this} {nameof(userToValidate)} threw an exception {e.Message}");
                throw new ArgumentException(e.Message);
            }

            string userAsJson = JsonSerializer.Serialize(userToValidate);
            StringContent payload = new StringContent(userAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync($"{RootUrl}/login", payload);
            if (!responseMessage.IsSuccessStatusCode)
            {
                string errorResponse = await responseMessage.Content.ReadAsStringAsync();
                // WebApiResponse errorResponse = JsonSerializer.Deserialize<WebApiResponse>(errorResponseAsJson);
                if (responseMessage.StatusCode == HttpStatusCode.Unauthorized ||
                    responseMessage.StatusCode == HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"response1: {errorResponse}");
                    throw new ArgumentException("Incorrect Password");
                }

                if (responseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"response2: {errorResponse}");

                    throw new KeyNotFoundException(errorResponse);
                }

                throw new Exception($"Error: {responseMessage.StatusCode}, {errorResponse}");
            }

            string validatedUserAsJson = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(
                $"{this} Received {validatedUserAsJson} as payload from request {nameof(this.ValidateUserAsync)}");
            User validatedUser = JsonSerializer.Deserialize<User>(validatedUserAsJson, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            Console.WriteLine($"{this} returning user: {validatedUser.Username}");
            return validatedUser;
        }
    }
}