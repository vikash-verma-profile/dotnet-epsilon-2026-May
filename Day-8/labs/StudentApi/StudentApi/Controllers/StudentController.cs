using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Business;
using Student.Data;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentService studentService;
        public StudentController(StudentService _studentService)
        {
            studentService=_studentService;
        }
        [Route("get-all-students")]
        [HttpGet]
        public IActionResult getAllStundents()
        {
            return Ok(studentService.GetStudents());
        }
    }
}
