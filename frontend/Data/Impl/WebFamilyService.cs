using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Dtos;
using DNPAssignment1FamilyManagementSystem.Extensions;
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
            Console.WriteLine(fetchedFamiliesAsJson);
            IList<Family> fetchedFamilies = JsonSerializer.Deserialize<List<Family>>(fetchedFamiliesAsJson, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            return fetchedFamilies;
        }

        public async Task CreateFamilyAsync(Family family)
        {
            using HttpClient client = new HttpClient();
            string createFamilyDtoAsJson = JsonSerializer.Serialize(family.AsDto());
            StringContent payload = new StringContent(createFamilyDtoAsJson, Encoding.UTF8, "application/json");

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
            Family fetchedFamily = JsonSerializer.Deserialize<Family>(fetchedFamilyAsJson);
            return fetchedFamily;
        }

        public async Task AddAdultToFamilyAsync(Family family, Adult adult)
        {
            using HttpClient client = new HttpClient();
            AddAdultDto addAdultDto = new AddAdultDto()
            {
                FamilyStreetName = family.StreetName, FamilyHouseNumber = family.HouseNumber,
                FirstName = adult.FirstName, LastName = adult.FirstName, HairColor = adult.HairColor, Age = adult.Age,
                Height = adult.Height, Sex = adult.Sex, Weight = adult.Weight, EyeColor = adult.EyeColor,
                JobTitle = adult.JobTitle
            };
            string addAdultDtoAsJson = JsonSerializer.Serialize(addAdultDto);
            StringContent payload = new StringContent(addAdultDtoAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync($"{RootUrl}/Adults", payload);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }

        public Task RemoveAdultFromFamilyAsync(Family family, Adult adult)
        {
            //TODO : implement this
            throw new System.NotImplementedException();
        }

        public Task RemoveChildFromFamilyAsync(Family family, Child child)
        {
            //TODO : implement this
            throw new System.NotImplementedException();
        }
    }
}