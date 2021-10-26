using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
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
            Console.WriteLine($"Request received for {nameof(GetFamily)}");
            var families = await _familiesRepository.GetFamiliesAsync();
            return Ok(families);
        }

        [HttpGet("{streetName}/{houseNumber:int}")]
        public async Task<ActionResult<Family>> GetFamily([FromRoute] string streetName, [FromRoute] int houseNumber)
        {
            Console.WriteLine($"Request received for {nameof(GetFamily)}");
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

   
        [HttpPost]
        public async Task<ActionResult<Family>> CreateFamily([FromBody] Family family)
        {
            try
            {
                Family createdFamily = await _familiesRepository.CreateFamilyAsync(family);
                return CreatedAtAction(nameof(GetFamily),
                    new {streetName = createdFamily.StreetName, houseNumber = createdFamily.HouseNumber},
                    createdFamily);
            }
            catch (ArgumentException e)
            {
                return Conflict(e.ToString());
            }
        }


        [HttpDelete("{streetName}/{houseNumber:int}")]
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