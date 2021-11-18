using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyManagementRestApi.DTOs;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Repositories;
using FamilyManagementRestApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FamilyManagementRestApi.Controllers
{
    //TODO: Move input validation from repository to controller 

    [ApiController]
    [Route("api/[controller]")]
    public class AdultsController : ControllerBase
    {

        private readonly IAdultsService _adultsService;
        private readonly IFamiliesService  _familiesService; 

        public AdultsController(IAdultsService adultsService, IFamiliesService familiesService)
        {
            _adultsService = adultsService;
            _familiesService = familiesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Adult>>> GetAdults([FromQuery(Name = "firstname")] string firstName,
            [FromQuery(Name = "lastname")] string lastName)
        {
            IEnumerable<Adult> adults = await _adultsService.GetAdultsAsync();
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
        public async Task<ActionResult<Adult>> GetAdult([FromRoute] int id)
        {
            try
            {
                Adult existingAdult = await _adultsService.GetAdultAsync(id);
                return Ok(existingAdult);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(e.Message);
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
            if (adultDto == null)
            {
                return BadRequest();
            }

            Family family = null;

            try
            {
                family = await _familiesService.GetFamilyAsync(adultDto.FamilyStreetName, adultDto.FamilyHouseNumber);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(e.Message); 
            }
            
            Adult adultToAdd = new()
            {
                FirstName = adultDto.FirstName, LastName = adultDto.LastName, Age = adultDto.Age,
                Height = adultDto.Height,
                EyeColor = adultDto.EyeColor, Sex = adultDto.Sex, Weight = adultDto.Weight,
                HairColor = adultDto.HairColor, Job = adultDto.JobTitle
            };
            Adult newAdult = null;
            try
            {
                newAdult = await _adultsService.AddAdultToFamilyAsync(family, adultToAdd);
            }
            catch (ArgumentException e)
            {
                BadRequest(e.Message); 
            }

            return CreatedAtAction(nameof(GetAdult), new {id = newAdult.Id}, newAdult);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Adult>> DeleteAdult([FromRoute] int id)
        {
            
            Adult deletedAdult = null;
            try
            {
                deletedAdult = await _adultsService.DeleteAdultAsync(id);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message); 
            }

            return Ok(deletedAdult);
        }
    }
}