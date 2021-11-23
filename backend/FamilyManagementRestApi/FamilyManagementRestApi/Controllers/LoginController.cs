using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.DTOs;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Repositories;
using FamilyManagementRestApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FamilyManagementRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public LoginController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpPost]
        public async Task<ActionResult<User>> LoginUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            Console.WriteLine($"Request for {nameof(LoginUser)}");

            User userToValidate = null;
            try
            {
                userToValidate = await _usersService.ValidateUserAsync(user.Username, user.Password);
                Console.WriteLine($"Request for {nameof(LoginUser)} was OK.");
                Console.WriteLine($"Returning user: {userToValidate.Username}");
                return Ok(userToValidate);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Exception was thrown for action {nameof(LoginUser)}");
                return Unauthorized(e.Message);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(e.Message);
            }

        }

    }
}