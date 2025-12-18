using Microsoft.AspNetCore.Mvc;

namespace API_NET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Get([FromHeader]int id, [FromHeader] string? nickname)
        {
            var response = new User
            {
                Id = 1,
                Age = 7,
                Name = "Juliano"
            };

            return Ok(response);
        }
    }
}
