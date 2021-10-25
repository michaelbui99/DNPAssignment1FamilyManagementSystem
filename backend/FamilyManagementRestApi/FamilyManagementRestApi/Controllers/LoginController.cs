using System.Threading.Tasks;
using FamilyManagementRestApi.DTOs;
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
            return null;
        }
        
    }
}