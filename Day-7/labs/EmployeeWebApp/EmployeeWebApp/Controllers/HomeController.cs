using EmployeeWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace EmployeeWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employeeList = new List<Employee>();
            string connectionString = "Data Source=DESKTOP-CUO3FKB;Initial Catalog=SampleDb5;Integrated Security=True;";

            SqlConnection con = new SqlConnection(connectionString);

            string query = "SELECT * FROM Employee";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                employeeList.Add(new Employee() { Id= Convert.ToInt32(reader["Id"]) ,Name= Convert.ToString(reader["text"]) });    
            }

            con.Close();
            return View(employeeList);
        }
    }
}
