using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Repositories;

namespace FamilyManagementRestApi.Services.Impl
{
    public class AdultsService : IAdultsService
    {

        private readonly IAdultsRepository _adultsRepository;
        private readonly IFamiliesService _familiesService;

        public AdultsService(IAdultsRepository adultsRepository, IFamiliesService familiesService)
        {
            _adultsRepository = adultsRepository;
            _familiesService = familiesService;
        }


        public async Task<IEnumerable<Adult>> GetAdultsAsync()
        {
            return await _adultsRepository.GetAdultsAsync(); 
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            Adult existingAdult = await _adultsRepository.GetAdultAsync(id);
            if (existingAdult == null)
            {
                throw new KeyNotFoundException($"No adult with id {id} exist"); 
            }

            return existingAdult; 
        }

        public async Task<Adult> AddAdultToFamilyAsync(Family family, Adult adult)
        {
            if (family == null)
            {
                throw new ArgumentException(); 
            }

            if (adult == null)
            {
                throw new ArgumentException(); 
            }

            if (family.Adults.Count >= 2){
                throw new ArgumentException("Max 2 adults is allowed per family"); 
            }

            try
            {
             await _familiesService.GetFamilyAsync(family.StreetName, family.HouseNumber); 
            }
            catch (KeyNotFoundException e)
            {
                throw new KeyNotFoundException(e.Message);
            }

            return await _adultsRepository.AddAdultToFamilyAsync(family, adult); 

        }

        public async Task<Adult> DeleteAdultAsync(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot less than 0"); 
            }

            Adult existingAdult = await _adultsRepository.GetAdultAsync(id);
            if (existingAdult == null)
            {
                throw new KeyNotFoundException($"No adult with id {id} exist"); 
            }

            Adult removedAdult = await _adultsRepository.RemoveAdultAsync(id);

            return removedAdult; 
        }
    }
}