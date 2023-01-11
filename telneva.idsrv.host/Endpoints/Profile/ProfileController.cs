using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace telneva.idsrv.host.Endpoints.Profile
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status400BadRequest)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status429TooManyRequests)]
    public class ProfileController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Get()
        {
            return Ok();
        }

        [HttpGet("List")]
        public async Task<ActionResult> List()
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Edit(Guid id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(Guid id)
        {
            return Ok();
        }

        [HttpPatch("{id}/archive")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Archive(Guid id)
        {
            return Ok();
        }

        [HttpPatch("{id}/password/reset")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> ResetPassword(Guid id)
        {
            return Ok();
        }
    }
}
