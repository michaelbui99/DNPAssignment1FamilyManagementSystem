using System;
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
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }


        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            try
            {
                User newUser = await _usersService.CreateUserAsync(user);
                return Ok(newUser);
            }
            catch (ArgumentException e)
            {
                return Conflict(e.Message);
            }
        }

        
     
    }
}