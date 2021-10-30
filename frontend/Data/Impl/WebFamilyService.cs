using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Dtos;
using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Data.Impl
{
    public class WebFamilyService : IFamilyService
    {
        private const string RootUrl = "https://localhost:5001/api";

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{RootUrl}/Families");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode} {responseMessage.ReasonPhrase}");
            }

            string fetchedFamiliesAsJson = await responseMessage.Content.ReadAsStringAsync();
            IList<Family> fetchedFamilies = JsonSerializer.Deserialize<List<Family>>(fetchedFamiliesAsJson, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            return fetchedFamilies;
        }

        public async Task CreateFamilyAsync(Family family)
        {
            using HttpClient client = new HttpClient();
            string familyAsJson = JsonSerializer.Serialize(family);
            StringContent payload = new StringContent(familyAsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync($"{RootUrl}/Families", payload);
            if (!responseMessage.IsSuccessStatusCode)
            {
                if (responseMessage.StatusCode == HttpStatusCode.Conflict)
                {
                    throw new ArgumentException(responseMessage.ReasonPhrase);
                }
            }
        }

        public async Task DeleteFamilyAsync(string streetName, int houseNumber)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage =
                await client.DeleteAsync($"{RootUrl}/Families/{streetName}/{houseNumber}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                if (responseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new KeyNotFoundException(responseMessage.ReasonPhrase);
                }

                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }

        public async Task<Family> GetFamilyAsync(string streetName, int houseNumber)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await
                client.GetAsync($"{RootUrl}/Families/{streetName}/{houseNumber}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                if (responseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new KeyNotFoundException(responseMessage.ReasonPhrase);
                }

                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string fetchedFamilyAsJson = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine($"{this} received {fetchedFamilyAsJson}");
            Family fetchedFamily = JsonSerializer.Deserialize<Family>(fetchedFamilyAsJson, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return fetchedFamily;
        }

        public async Task AddAdultToFamilyAsync(Family family, Adult adult)
        {
            using HttpClient client = new HttpClient();
            Console.WriteLine($"{this} {nameof(AddAdultToFamilyAsync)} was passed Family: {family.StreetName}, {family.HouseNumber}");
            AddAdultDto addAdultDto = new AddAdultDto()
            {
                FamilyStreetName = family.StreetName, FamilyHouseNumber = family.HouseNumber,
                FirstName = adult.FirstName, LastName = adult.LastName, HairColor = adult.HairColor, Age = adult.Age,
                Height = adult.Height, Sex = adult.Sex, Weight = adult.Weight, EyeColor = adult.EyeColor,
                JobTitle = adult.JobTitle
            };
            string addAdultDtoAsJson = JsonSerializer.Serialize(addAdultDto, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            StringContent payload = new StringContent(addAdultDtoAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync($"{RootUrl}/Adults", payload);
            if (!responseMessage.IsSuccessStatusCode)
            {
                string errorResponse = await responseMessage.Content.ReadAsStringAsync();
                throw new Exception($"Error: {responseMessage.StatusCode}, {errorResponse}");
            }
        }

        public async Task RemoveAdultFromFamilyAsync(Family family, Adult adult)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.DeleteAsync($"{RootUrl}/adults/{adult.Id}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                string errorMessage = await responseMessage.Content.ReadAsStringAsync();
                if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
                {
                    throw new ArgumentException(errorMessage);
                }

                if (responseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new KeyNotFoundException(errorMessage);
                }
            }
        }

        public Task RemoveChildFromFamilyAsync(Family family, Child child)
        {
            //TODO : implement this
            throw new System.NotImplementedException();
        }
    }
}