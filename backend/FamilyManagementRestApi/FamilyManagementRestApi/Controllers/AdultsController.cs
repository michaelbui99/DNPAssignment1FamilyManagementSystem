using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    [Route("api/[controller]")]
    public class AdultsController : ControllerBase
    {
        private IFamiliesRepository _familiesRepository;
        private IAdultsRepository _adultsRepository;

        public AdultsController(IFamiliesRepository familiesRepository, IAdultsRepository adultsRepository)
        {
            _familiesRepository = familiesRepository;
            _adultsRepository = adultsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Adult>>> GetAdults([FromQuery(Name = "firstname")]string firstName, [FromQuery(Name="lastname")] string lastName)
        {
            IEnumerable<Adult> adults = await _adultsRepository.GetAdultsAsync();
            if (firstName != null)
            {
                adults = adults.Where(a => a.FirstName.ToLower().Contains(firstName.ToLower())).ToList(); 
            }

            if (lastName != null)
            {
                adults = adults.Where(a => a.LastName.ToLower().Contains(lastName.ToLower())).ToList(); 
            }
            return Ok(adults);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Adult>> GetAdult([FromRoute]int id)
        {
            try
            {
                Adult adultToReturn = await  _adultsRepository.GetAdultAsync(id);
                return Ok(adultToReturn);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(); 
            }
            
        }

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

                Adult newAdult = await _adultsRepository.AddAdultToFamilyAsync(family, adultToAdd);

                return CreatedAtAction(nameof(GetAdult), new {id = newAdult.Id}, newAdult);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Family does not exist");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Adult>> DeleteAdult([FromRoute] int id)
        {
            Task<Adult> removeAdult; 
            try
            {
                removeAdult =  _adultsRepository.RemoveAdultAsync(id);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(e.Message);
            }

            
            return Ok(await removeAdult);
        }
    }
}