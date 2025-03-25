using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_web_apps.Models;

namespace mvc_web_apps.Controllers
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
            User user = new User
            {
                Name = "Ema",
                Email = "ema@example.com",
                Age = 21
            };

            return View(user);  // Pasamos el objeto User a la vista
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
