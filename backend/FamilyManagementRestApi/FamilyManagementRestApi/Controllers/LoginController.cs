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
    public class LoginController
    {
        private IUsersRepository _usersRepository;

        public LoginController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpPost]
        public async Task<ActionResult<LoginResponseDto>> LoginUser([FromBody] LoginRequestDto loginRequestDto)
        {
            string exceptionMessage = null;
            User userToValidate = null;

            try
            {
                userToValidate =
                    await _usersRepository.ValidateUserAsync(loginRequestDto.Username, loginRequestDto.Password);
            }
            catch (Exception e)
            {
                exceptionMessage = e.Message;
            }

            LoginResponseDto response = new LoginResponseDto()
            {
                User = userToValidate, ErrorMessage = exceptionMessage
            }; 
            
            return response;
        }
        
    }
}