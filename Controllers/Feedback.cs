using Microsoft.AspNetCore.Mvc;
using MRV_resturant.Data;
using MRV_resturant.Models;


namespace MRV_resturant.Controllers
{
	public class Feedback : Controller
    {
        private readonly UserDbContext _context;

        public Feedback(UserDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult feedback() { return View(); }

        [HttpPost]
        public IActionResult feedback(FeedbackModel model)
        {
            if (ModelState.IsValid)
            {
                _context.DB01T03.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home"); 
            }
            return View(model);
        }
        
    }
}
