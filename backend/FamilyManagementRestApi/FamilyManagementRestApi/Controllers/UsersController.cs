using System;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FamilyManagementRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IUsersRepository _usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }


        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] User user)
        {
            try
            {
                Console.WriteLine($"{this} {nameof(CreateUser)} called");
                await _usersRepository.CreateUserAsync(user);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return Conflict(e.Message);
            }
        }

        
     
    }
}