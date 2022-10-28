using Microsoft.AspNetCore.Mvc;
using UserAuthProject.Models;

namespace UserAuthProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Login İşlemleri
            }

            return View(model);
        }
        public IActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Register İşlemleri
            }
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
