using Microsoft.AspNetCore.Mvc;
using MRV_resturant.Models;
using MRV_resturant.Data;

namespace MRV_resturant.Controllers
{
    public class Login : Controller
    {
        private readonly UserDbContext _context;

        public Login(UserDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Signup_page()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup_page(RegistrestionModel model)
        {
            if (ModelState.IsValid)
            {
                _context.DB01T01.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        // login action

        [HttpGet]
        public IActionResult Login_page()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login_page(LoginModel model)
        {

            var user = _context.DB01T01.FirstOrDefault(u => u.Email == model.Email);
            
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid email or password");
                return View("Login_page", model);
            }
            else
            
            {
                if (user.Password != model.Password)
                {
                    return View("Login_page", model);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
                
            }
        }
    }
}
