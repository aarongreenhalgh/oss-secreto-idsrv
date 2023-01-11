using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace telneva.idsrv.host.Endpoints.Email
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status400BadRequest)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status429TooManyRequests)]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> Add()
        {
            return Created("", "");
        }

        [HttpPost("Template")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> AddTemplate()
        {
            return Created("", "");
        }

        [HttpGet("Template/{id}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status200OK)]
        public async Task<ActionResult> Get()
        {
            return Created("", "");
        }   

        [HttpGet("Template/List")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status200OK)]
        public async Task<ActionResult> List()
        {
            return Created("", "");
        }   
    }
}
