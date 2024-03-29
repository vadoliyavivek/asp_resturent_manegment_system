using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class Profile : Controller
    {
        public IActionResult profile()
        {
            return View();
        }

        public IActionResult Edit_profile()
        {
            return View();
        }
    }
}
