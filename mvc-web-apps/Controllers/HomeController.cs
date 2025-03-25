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

        [HttpGet]
        public IActionResult Index()
        {
            return View();  // Muestra el formulario vacío
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            // Aquí, `user` contiene los datos enviados desde el formulario
            ViewData["Message"] = $"Welcome {user.Name}!";
            ViewData["UserEmail"] = user.Email;
            ViewData["UserAge"] = user.Age;

            return View();  // Vuelve a mostrar la vista con los datos ingresados
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
