using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class Feedback : Controller
    {
        public IActionResult feedback()
        {
            return View();
        }
    }
}
