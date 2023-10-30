using FirstDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstDemo.Controllers
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
            ViewData["message"] = "This is sample text in viewdata";
            List<string> names = new List<string>()
            {
                "Akshay","Amol","Tushar","Vivek","Kishor"
            };
            ViewData["list"] = names; // implict --> object
            

            List<string> city = new List<string>()
            {
                "Mumbai","Pune","Nashik","Nagar","Solapur","Satara"
            };

            ViewBag.Date = 13;
            ViewBag.Month = "Feb";
            ViewBag.Year = 2001;
            ViewBag.Day = "Thuesdsay";
            ViewBag.City = city;

            TempData["Company"] = "Think Quotient";
            TempData.Keep("Company");

            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
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