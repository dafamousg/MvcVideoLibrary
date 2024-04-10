using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcICT.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name = "Unknown", int ID = 1, int age = 0)
        {
            if (age < 18)
            {
                ViewData["Message"] = $"You know you shouldn't be on this site!";
            }
            else
            {
                ViewData["Message"] = $"Welcome back {name}!";
            }

            ViewData["id"] = ID;
            ViewData["age"] = age;
            ViewData["name"] = name;


            return View();
        }
    }
}
