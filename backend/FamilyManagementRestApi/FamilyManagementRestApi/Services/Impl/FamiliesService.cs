using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Repositories;

namespace FamilyManagementRestApi.Services.Impl
{
    public class FamiliesService : IFamiliesService
    {
        private IFamiliesRepository _familiesRepository;

        public FamiliesService(IFamiliesRepository familiesRepository)
        {
            _familiesRepository = familiesRepository;
        }

        public async Task<Family> GetFamilyAsync(string streetName, int houseNumber)
        {
            if (streetName == null)
            {
                throw new ArgumentException("streetName cannot be null");
            }

            if (houseNumber < 0)
            {
                throw new ArgumentException("houseNumber cannot be less than 0");
            }
            Family existingFamily = await _familiesRepository.GetFamilyAsync(streetName, houseNumber);
            if (existingFamily == null)
            {
                throw new KeyNotFoundException("Family does not exist");
            }

            return existingFamily;
        }

        public async Task<IEnumerable<Family>> GetFamiliesAsync()
        {
            return await _familiesRepository.GetFamiliesAsync();
        }

        public async Task<Family> DeleteFamilyAsync(string streetName, int houseNumber)
        {
            if (streetName == null)
            {
                throw new ArgumentException("streetName cannot be null");
            }

            if (houseNumber < 0)
            {
                throw new ArgumentException("houseNumber cannot be less than 0"); 
            }

            if (!FamilyExists(streetName, houseNumber))
            {
                throw new KeyNotFoundException("Family does not exist"); 
            }

            return await _familiesRepository.DeleteFamilyAsync(streetName, houseNumber);

        }

        public async Task<Family> CreateFamilyAsync(Family family)
        {
            if (family == null)
            {
                throw new ArgumentException("family cannot be null");
            }

            if (FamilyExists(family.StreetName, family.HouseNumber))
            {
                throw new ArgumentException("Family already exist"); 
            }

            return await _familiesRepository.CreateFamilyAsync(family);
        }

        public bool FamilyExists(string streetName, int houseNumber)
        {
            Family existingFamily = _familiesRepository.GetFamilyAsync(streetName, houseNumber).Result;
            if (existingFamily == null)
            {
                return false; 
            }

            return true; 
        }
    }
}