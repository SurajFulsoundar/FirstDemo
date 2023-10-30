using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace FirstDemo.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult StudentDetails()
        {
            List<string> sub = new List<string>()
            {
                "C#","C","Python","Java","C++","HTML","CSS","Bootstrap","Java Script"
            };

            ViewData["sub"] = new SelectList(sub);

            List<string> city = new List<string>()
            {
                "Solapur","Sangali","Satara","Pune","Mumbai","Nashik","Nagar"
            };

            ViewData["city"] = new SelectList(city);

            return View();

           

        }
        [HttpPost]

        public IActionResult StudentDetails(IFormCollection form)
        {
            ViewBag.Roll_No = form["rollno"];
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["gender"];
            ViewBag.Subject = form["sub"];
            ViewBag.City = form["city"];
            ViewBag.Subject = form["sub"];



            return View("Student_DisplayDetails");
        }
    }
}
