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
        public string Number { get; set; }

        public string Password { get; set; }

        public byte[] ProfileImage { get; set; }
    }
}
