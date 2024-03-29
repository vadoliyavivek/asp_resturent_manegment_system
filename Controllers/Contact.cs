using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MRV_resturant.Data;
using MRV_resturant.Models;

namespace MRV_resturant.Controllers
{
	public class Contact : Controller
    {
        private readonly UserDbContext _context;

        public Contact(UserDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult contact ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult contact(ContectModel model)
        {

            if (ModelState.IsValid)
            {
                _context.DB01T05.Add(model);
                _context.SaveChanges();
                return RedirectToAction("contact", "Contact");
            }
            return View(model);

            
        }
    }
}
