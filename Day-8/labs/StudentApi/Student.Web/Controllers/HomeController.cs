using Microsoft.AspNetCore.Mvc;
using Student.Web.Models;
using Student.Web.Services;
using System.Diagnostics;

namespace Student.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IStudentService _service;

        public HomeController(ILogger<HomeController> logger,IStudentService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentList()
        {
            var data = _service.GetStudents();
            return View(data);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
