using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class Reservation : Controller
    {
        public IActionResult reservation()
        {
            return View();
        }
    }
}
