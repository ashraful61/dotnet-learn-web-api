using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        [HttpGet("get-all")]
        public IActionResult GetAllAbout()
        {
            var abouts = new List<AboutModel>()
            {
                new AboutModel() {Title="About 1 Text"}
            };
            return Ok(abouts);
        }
    }
}
