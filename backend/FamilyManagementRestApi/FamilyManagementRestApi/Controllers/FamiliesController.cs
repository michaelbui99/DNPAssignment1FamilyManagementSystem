using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Repositories;
using FamilyManagementRestApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FamilyManagementRestApi.Controllers
{
    //TODO: Move input validation from repository to controller 
    [ApiController]
    [Route("api/[controller]")]
    public class FamiliesController : ControllerBase
    {
        private readonly IFamiliesService _familiesService; 

        public FamiliesController(IFamiliesService familiesService)
        {
            _familiesService = familiesService; 
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Family>>> GetFamilies([FromQuery] string streetName, [FromQuery] int? houseNumber)
        {
            Console.WriteLine($"Request received for {nameof(GetFamily)}");
            var families = await _familiesService.GetFamiliesAsync();
            if (streetName != null)
            {
                families = families.Where(f => f.StreetName.ToLower().Contains(streetName.ToLower())); 
            }

            if (houseNumber != null)
            {
                families = families.Where((f => f.HouseNumber == houseNumber)); 
            }
            return Ok(families);
        }

        [HttpGet("{streetName}/{houseNumber:int}")]
        public async Task<ActionResult<Family>> GetFamily([FromRoute] string streetName, [FromRoute] int houseNumber)
        {
            Console.WriteLine($"Request received for {nameof(GetFamily)}");
            try
            {
                Family family = await _familiesService.GetFamilyAsync(streetName, houseNumber);
                Console.WriteLine(
                    $"{this} {nameof(GetFamily)} returning Family: {family.StreetName},{family.HouseNumber}");
                return Ok(family);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound();
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message); 
            }
        }

   
        [HttpPost]
        public async Task<ActionResult<Family>> CreateFamily([FromBody] Family family)
        {
            try
            {
                Family createdFamily = await _familiesService.CreateFamilyAsync(family);
                return CreatedAtAction(nameof(GetFamily),
                    new {streetName = createdFamily.StreetName, houseNumber = createdFamily.HouseNumber},
                    createdFamily);
            }
            catch (ArgumentException e)
            {
                return Conflict(e.Message);
            }
        }


        [HttpDelete("{streetName}/{houseNumber:int}")]
        public async Task<ActionResult<Family>> DeleteFamily([FromRoute] string streetName, [FromRoute] int houseNumber)
        {
            try
            {
                Family deletedFamily = await _familiesService.DeleteFamilyAsync(streetName, houseNumber);
                return Ok(deletedFamily);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound();
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }


       
    }
}