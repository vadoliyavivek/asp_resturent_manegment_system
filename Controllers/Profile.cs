using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MRV_resturant.Data;
using MRV_resturant.Models;
using System.IO;
using System.Linq;

namespace MRV_resturant.Controllers
{
    public class Profile : Controller
    {
        private readonly UserDbContext _context;

        public Profile(UserDbContext context)
        {
            _context = context;
        }

        public IActionResult profile()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit_profile()
        {
            var user = _context.DB01T01.FirstOrDefault(); // Assuming there's only one user record for simplicity

            // Pass the user data to the view
            return View(user);
        }

        [HttpPost]
        public IActionResult update_profile(RegistrestionModel model)
        {
            var user = _context.DB01T01.FirstOrDefault();
            if (user != null)
            {
                user.ProfileImage = model.ProfileImage;
                _context.SaveChanges();
            }
            return View(user);
         }

        [HttpPost]
        public IActionResult Edit_profile(RegistrestionModel model)
        {
           
            
                
                var user = _context.DB01T01.FirstOrDefault(); 

                if (user != null)
                {
                    // Update user profile with the data from the submitted form
                    user.Name = model.Name;
                    user.Email = model.Email;
                   // user.Number = model.Number;
                   
                    

                    // Save changes to the database
                    _context.SaveChanges();

                    // Redirect to the profile page or any other appropriate page
                    return RedirectToAction("Edit_profile");
                }
            

            // If ModelState is not valid or the user is not found, return the view with the model to display validation errors
            return View(model);
        }

        [HttpPost]
        public IActionResult RemoveImage(RegistrestionModel model)
        {
            // Find the user in the database based on their unique identifier
            var user = _context.DB01T01.FirstOrDefault(u => u.Email == model.Email);

            if (user != null)
            {
                // Remove the profile image
                user.ProfileImage = null;
                _context.SaveChanges();
            }

            // Redirect to the edit profile page after removing the image
            return RedirectToAction("Edit_profile");
        }

        [HttpPost]
        public IActionResult UpdateProfilePicture(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyTo(memoryStream);
                    var imageData = memoryStream.ToArray();

                    // Find the user in the database based on their unique identifier
                    var user = _context.DB01T01.FirstOrDefault();

                    if (user != null)
                    {
                        user.ProfileImage = imageData;
                        _context.SaveChanges();
                    }
                }
            }

            // Redirect to the edit profile page or any other appropriate page
            return RedirectToAction("Edit_profile");
        }
    }
}
