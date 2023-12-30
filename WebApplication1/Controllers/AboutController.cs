using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private List<AboutModel> _aboutsData;

        public AboutController()
        {
            _aboutsData = new List<AboutModel>()
            {
                new AboutModel() { Id = 1, Title = "Title one", Description = "Desc one" },
                new AboutModel() { Id = 2, Title = "Title two",  Description = "Desc two" }
            };
        }


        [HttpGet("")]
        public IActionResult GetAllAbout()
        {
            return Ok(_aboutsData);
        }



        [HttpPost("")]
        public IActionResult PostAbout(AboutModel about)
        {
            _aboutsData.Add(about);
            return CreatedAtAction("postaboutmethod",new { id = about.Id }, about);
        }


        [HttpGet("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }

            return Ok(_aboutsData);
        }


        [HttpGet("GetById/{id:int}")]
        public IActionResult GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var about = _aboutsData.FirstOrDefault(x => x.Id == id);
            if(about != null)
            {
                return NotFound($"Data not found with the {id}");
            }

            return Ok(about);
        }

        [HttpGet("as")]

        public IActionResult LocalRedirect()
        {
            return LocalRedirect("~/api/v1/test");
        }



    }
}
