using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MRV_resturant.Models
{
    public class RegistrestionModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Mobile number must be numeric")]
        public string Number { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Password must be at least 2 characters long")]
        public string Password { get; set; }
    }
}
