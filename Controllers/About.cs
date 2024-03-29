using Microsoft.AspNetCore.Mvc;

namespace MRV_resturant.Controllers
{
	public class About : Controller
    {
        public IActionResult about()
        {
            return View();
        }
    }
}
