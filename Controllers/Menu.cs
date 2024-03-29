using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class Menu : Controller
    {
        public IActionResult menu()
        {
            return View();
        }

        public IActionResult Pizza()
        {
            return View();
        }

        public IActionResult Fastfood()
        {
            return View();
        }

        public IActionResult BURGGER()
        {
            return View();
        }

        public IActionResult All_Dishes()
        {
            return View();
        }

        public IActionResult Juice()
        {
            return View();
        }

        public IActionResult Drinks()
        {
            return View();
        }
    }
}
