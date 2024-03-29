using System.ComponentModel.DataAnnotations;

namespace MRV_resturant.Models
{
    public class LoginModel
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Password must be at least 2 characters long")]
        public string Password { get; set; }
    }
}
