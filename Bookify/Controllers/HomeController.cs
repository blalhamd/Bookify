using Bookify.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bookify.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

		public IActionResult Test()
		{
            var emps = new List<Employee>()
            {
new Employee
            {
                Id = 1,
                Name = "Mohamed Maher galby",
                SSN = "19002810281028102",
                Level = 3
            },
new Employee
            {
                Id = 1,
                Name = "Mohamed Maher galby",
				SSN = "19002810281028102",
				Level = 3
			},
        };

			return View(emps);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
