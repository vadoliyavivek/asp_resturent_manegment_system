using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class About : Controller
    {
        public IActionResult about()
        {
            return View();
        }
    }
}
