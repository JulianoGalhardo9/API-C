using API_NET.Communication.Request;
using API_NET.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace API_NET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetById([FromRoute]int id)
        {
            var response = new User
            {
                Id = 1,
                Age = 7,
                Name = "Juliano"
            };

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody]RequestRegisterUserJson request)
        {
            var response = new ResponseRegisterUserJson
            {
                Id = 1,
                Name = request.Name,
            };

            return Created(string.Empty, response);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update(
            [FromBody] RequestUpdateUserProfileJson request)
        {
            return NoContent();
        }
    }
}
