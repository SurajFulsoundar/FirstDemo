using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstDemo.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<string> city = new List<string>()
            {
                "Solapur","Sangali","Satara","Pune","Mumbai","Nashik","Nagar"
            };

            ViewData["city"] = new SelectList(city);
            return View();
        }

        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form, ICollection<string> hobbies)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["city"];
            ViewBag.Hobbies = hobbies;
            return View("Person_DisplayDetails");
        }

    }
}
