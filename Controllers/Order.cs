using Microsoft.AspNetCore.Mvc;

namespace MRV_resturant.Controllers
{
    public class Order : Controller
    {
        public IActionResult order()
        {
            return View();
        }
    }
}
