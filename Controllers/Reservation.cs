using Microsoft.AspNetCore.Mvc;
using MRV_resturant.Data;
using MRV_resturant.Models;

namespace MRV_resturant.Controllers
{
    public class Reservation : Controller
    {
        private readonly UserDbContext _context;

        public Reservation(UserDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult reservation() 
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult reservation(ReservationModel model)
        {
            if (ModelState.IsValid)
            {
                _context.DB01T02.Add(model);
                _context.SaveChanges();
                ViewBag.Message = "Your table is confirmed!";
                return View(model);
            }
            return View(model);

        }
    }
}