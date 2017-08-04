using Microsoft.AspNetCore.Mvc;

namespace SampleMvcCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This description is not very descriptive.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Don't contact me... pfft!";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
