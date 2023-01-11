using Microsoft.AspNetCore.Mvc;

namespace telneva.idsrv.host.Endpoints.Login
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status400BadRequest)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status429TooManyRequests)]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> Login()
        {
            return Created("", "");
        }
    }
}
