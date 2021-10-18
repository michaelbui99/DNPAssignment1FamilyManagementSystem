using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using FamilyManagementRestApi.DTOs;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FamilyManagementRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FamiliesController : ControllerBase
    {
        private IFamiliesRepository _familiesRepository;

        public FamiliesController(IFamiliesRepository familiesRepository)
        {
            _familiesRepository = familiesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Family>>> GetFamilies()
        {
            var families = await _familiesRepository.GetFamiliesAsync();
            return Ok(families);
        }

        [HttpGet]
        [Route("/{streetName}/{houseNumber:int}")]
        public async Task<ActionResult<Family>> GetFamily([FromRoute] string streetName, [FromRoute] int houseNumber)
        {
            try
            {
                Family family = await _familiesRepository.GetFamilyAsync(streetName, houseNumber);
                return Ok(family);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Takes an CreateFamilyDto instead of Family,
        /// such that the user doesn't need to initialize the adults list, children list and pets list in the HTTP JSON payload.
        /// This method is assumes the user wants to create a new Family without any members and manually
        /// add family members afterwards. 
        /// </summary>
        /// <param name="familyDto">FamilyDto used for creating a new family</param>
        [HttpPost]
        public async Task<ActionResult<Family>> CreateFamily([FromBody] CreateFamilyDto familyDto)
        {
            try
            {
                Family familyToCreate = new Family()
                {
                    StreetName = familyDto.StreetName, HouseNumber = familyDto.HouseNumber, Adults = new(),
                    Children = new(), Pets = new()
                };
                await _familiesRepository.CreateFamilyAsync(familyToCreate);
                return CreatedAtAction(nameof(GetFamily),
                    new {streetName = familyToCreate.StreetName, houseNumber = familyToCreate.HouseNumber},
                    familyToCreate);
            }
            catch (ArgumentException e)
            {
                return Conflict(e.ToString());
            }
        }


        [HttpDelete]
        [Route("{streetName}/{houseNumber}")]
        public async Task<ActionResult<Family>> DeleteFamily([FromRoute] string streetName, [FromRoute] int houseNumber)
        {
            try
            {
                await _familiesRepository.DeleteFamilyAsync(streetName, houseNumber);
                return NoContent();
            }
            catch (KeyNotFoundException e)
            {
                return NotFound();
            }
        }


       
    }
}