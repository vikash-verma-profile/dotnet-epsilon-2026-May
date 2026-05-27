using EmployeeApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    //api/employee
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //public static List<Employee> employees = new List<Employee>()
        //{ new Employee { Id=101,Name="Rakesh"},
        //    new Employee {  Id=102,Name="Varun"} };
        SampleDb5Context db = new SampleDb5Context();
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(db.Employees);
        }
        [HttpPost]
        public IActionResult PostEmployee(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return Ok(new { Message = "record added sucessfully!!." });
        }
        [HttpPut("{id}")]
        public IActionResult GetName(int id, Employee emp)
        {
            var employee = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (employee == null)
            {
                return BadRequest("Employee is not present...");
            }
            employee.Text = emp.Text;
            db.SaveChanges();
            return Ok(new { Message = "record updated sucessfully!!." });
        }
        [HttpDelete("{id}")]
        public IActionResult GetName(int id)
        {
            var employee = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (employee == null)
            {
                return BadRequest("Employee is not present...");
            }
            db.Employees.Remove(employee);
            db.SaveChanges();
            return Ok(new { Message = "record deleted sucessfully!!." });
        }
    }
}
