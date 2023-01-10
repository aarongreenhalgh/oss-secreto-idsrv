using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace telneva.idsrv.api.host.Endpoints.User
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status400BadRequest)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status429TooManyRequests)]
    public class PasswordController : ControllerBase
    {
        [HttpGet("Generate")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> Generate()
        {
            return Created("", "");
        }

        [HttpPost("Health")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status200OK)]
        public async Task<ActionResult> Health()
        {
            return Created("", "");
        }   
    }
}
