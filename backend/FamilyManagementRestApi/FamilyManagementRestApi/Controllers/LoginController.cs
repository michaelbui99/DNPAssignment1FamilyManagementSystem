using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyManagementRestApi.DTOs;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FamilyManagementRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private IUsersRepository _usersRepository;

        public LoginController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpPost]
        public async Task<ActionResult<User>> LoginUser([FromBody] User user)
        {

            try
            {
                    await _usersRepository.ValidateUserAsync(user.Username, user.Password);
            }
            catch (Exception e)
            {
                return Unauthorized(e.Message);
            }

            
            return user;
        }
        
    }
}