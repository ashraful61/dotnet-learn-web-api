using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Hello()
        {
            return Ok("Hello");
        }
    }
}
