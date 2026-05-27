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
        public static List<Employee> employees = new List<Employee>() 
        { new Employee { Id=101,Name="Rakesh"},
            new Employee {  Id=102,Name="Varun"} };
       
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(employees);
        }
        [HttpPost]
        public IActionResult PostEmployee(Employee emp)
        {
            employees.Add(emp);
            return Ok(new { Message="record added sucessfully!!." });
        }
        [HttpPut("{id}")]
        public IActionResult GetName(int id,Employee emp)
        {
            var employee = employees.Where(x => x.Id == id).FirstOrDefault();
            if (employee == null)
            {
                return BadRequest("Employee is not present...");
            }
            employee.Name = emp.Name;
            return Ok(new { Message = "record updated sucessfully!!." });
        }
        [HttpDelete("{id}")]
        public IActionResult GetName(int id)
        {
            var employee = employees.Where(x => x.Id == id).FirstOrDefault();
            if (employee == null)
            {
                return BadRequest("Employee is not present...");
            }
            employees.Remove(employee);
            return Ok(new { Message = "record deleted sucessfully!!." });
        }
    }
}
