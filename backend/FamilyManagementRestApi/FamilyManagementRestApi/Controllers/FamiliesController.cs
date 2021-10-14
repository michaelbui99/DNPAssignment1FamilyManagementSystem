using FamilyManagementRestApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FamilyManagementRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamiliesController : ControllerBase
    {
        private IFamiliesRepository _familiesRepository;

        public FamiliesController(IFamiliesRepository familiesRepository)
        {
            _familiesRepository = familiesRepository;
        }
    }
}