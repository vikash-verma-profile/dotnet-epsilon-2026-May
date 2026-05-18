using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok("Vikash");
        }

        [HttpPost]
        public IActionResult PostStudents([FromBody]Student student)
        {
            return Ok("Vikash");
        }

        [HttpPut("id")]
        public IActionResult UpdateStudents([FromQuery] int id,[FromBody] Student student)
        {
            return Ok("Vikash");
        }
        [HttpDelete("id")]
        public IActionResult DeleteStudent([FromQuery] int id)
        {
            return Ok("Vikash");
        }
    }
}
