using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace telneva.idsrv.api.host.Endpoints.Register
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status400BadRequest)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status429TooManyRequests)]
    public class RegisterController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> Register()
        {
            return Created("", "");
        }

        [HttpPost("admin")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> RegisterAdmin()
        {
            return Created("", "");
        }      
    }
}
