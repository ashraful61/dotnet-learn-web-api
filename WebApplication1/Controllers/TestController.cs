using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("Hello")]
        public IActionResult Hello()
        {
            return Ok("Hello");
        }
    }
}
