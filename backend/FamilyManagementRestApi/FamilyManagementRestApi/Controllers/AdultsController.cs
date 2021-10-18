using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.DTOs;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FamilyManagementRestApi.Controllers
{
    /*
     *  Adults have their own endpoint instead of having the api/Families/{streetName}/{houseNumber}/Adults endpoint.
     * Giving Adults its own endpoints enables the client get a list of all adults in the system while still being able
     * to get adults from a specific family by passing request params instead of hitting the specific family's endpoint.  
    */
    
    [ApiController]
    [Route("api/adults")]
    public class AdultsController : ControllerBase
    {
        private IFamiliesRepository _familiesRepository;
        private IAdultsRepository _adultsRepository;


        /// <summary>
        /// Method takes an AddAdultDto instead of Adult, such that the user doesn't have to initialize an ID for the Adult and
        /// such that the user is required to specify which family the adult is part of. 
        /// ID assignment is handled by <see cref="IFamiliesRepository"/>
        /// </summary>
        /// <param name="adultDto">AdultDto for getting all necessary information to create the adult
        /// to the correct family as an Adult must belong to a Family.</param>
        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdultToFamily([FromBody] AddAdultDto adultDto)
        {
            try
            {
                Adult adultToAdd = new Adult()
                {
                    FirstName = adultDto.FirstName, LastName = adultDto.LastName, Age = adultDto.Age,
                    Height = adultDto.Height,
                    EyeColor = adultDto.EyeColor, Sex = adultDto.Sex, Weight = adultDto.Weight,
                    HairColor = adultDto.HairColor, JobTitle = adultDto.JobTitle
                };

                Family family = await _familiesRepository.GetFamilyAsync(adultDto.FamilyStreetName, adultDto.FamilyHouseNumber);

                Adult newAdult = await _familiesRepository.AddAdultToFamilyAsync(family, adultToAdd);

                return Created($"adults/{newAdult.Id}", newAdult);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Family does not exist");
            }
        }
    }
}