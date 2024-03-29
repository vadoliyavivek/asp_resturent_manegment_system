using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class Login : Controller
    {
        public IActionResult Login_page()
        {
            return View();
        }

        public IActionResult Signup_page()
        {
            return View();
        }
    }
}
