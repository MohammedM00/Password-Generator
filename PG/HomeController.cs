using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;

namespace PasswordGenerator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Generate(int length)
        {
            var passwordGenerator = new PasswordGenerator();
            var password = passwordGenerator.GeneratePassword(length);

            ViewBag.Password = password;
            return View("Index");
        }
    }
}
