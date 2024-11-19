using Microsoft.AspNetCore.Mvc;

namespace RestMatch.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PingController : ControllerBase
    {
        // GET: api/ping
        [HttpGet]
        public IActionResult GetPing()
        {
            return Ok(new { message = "pong", timestamp = DateTime.UtcNow });
        }

        // POST: api/ping
        [HttpPost]
        public IActionResult PostPing([FromBody] object requestBody)
        {
            return Ok(new { message = "pong", received = requestBody, timestamp = DateTime.UtcNow });
        }
    }
}
