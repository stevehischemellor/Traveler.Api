using Microsoft.AspNetCore.Mvc;
using Traveler.Api.Models;

namespace Traveler.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotoController : ControllerBase
    {       
        private readonly ILogger<PhotoController> _logger;

        public PhotoController(ILogger<PhotoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPhoto")]
        [Route("photo/{id}")]
        public Photo GetResume(int id)
        {
            return new Photo();
        }

        [HttpGet(Name = "GetExperience")]
        [Route("photo/{id}/experience/{experienceId}")]
        public Photo GetResumeExperience(int id, int experienceId)
        {
            return new Photo();
        }


    }
}