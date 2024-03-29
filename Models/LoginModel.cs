using System.ComponentModel.DataAnnotations;

namespace MRV_resturant.Models
{
    public class LoginModel
    {

        [Required]
        public int Id { get; set; }

        [Key]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Password must be at least 2 characters long")]
        public string Password { get; set; }

        public byte[] ProfileImage { get; set; }
    }
}
