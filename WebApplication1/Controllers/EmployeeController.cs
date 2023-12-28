using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("get-all")]
        public List<EmployeeModel> GetAllEmployees()
        {
            return new List<EmployeeModel>()
            {
                new EmployeeModel() { Id = 1, Name = "Employee 1" },
                new EmployeeModel() { Id = 2, Name = "Employee 2" },
                new EmployeeModel() { Id = 3, Name = "Employee 3" },
            };
        }

        [HttpGet("get-by-id/{id}")]

        public ActionResult<EmployeeModel> GetEmployeeById(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return new EmployeeModel() { Id = 1, Name = "Employee 1" };

        }
    }
}
