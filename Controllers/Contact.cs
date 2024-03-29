using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class Contact : Controller
    {
        public IActionResult contact()
        {
            return View();
        }
    }
}
