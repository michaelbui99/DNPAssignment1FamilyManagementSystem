using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Data.Impl
{
    public class RestFamilyService : IFamilyService
    {
        private const string RootUrl = "https://localhost:5001/api/"; 
        
        public async Task<IList<Family>> GetFamiliesAsync()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{RootUrl}/families");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode} {responseMessage.ReasonPhrase}");
            }

            return null; 
        }

        public Task CreateFamilyAsync(Family family)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteFamilyAsync(string streetName, int houseNumber)
        {
            throw new System.NotImplementedException();
        }

        public Task<Family> GetFamilyAsync(string streetName, int houseNumber)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAdultToFamilyAsync(Family family, Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveAdultFromFamilyAsync(Family family, Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveChildFromFamilyAsync(Family family, Child child)
        {
            throw new System.NotImplementedException();
        }
    }
}