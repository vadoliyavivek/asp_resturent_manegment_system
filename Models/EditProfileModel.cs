using System.ComponentModel.DataAnnotations;

namespace MRV_resturant.Models
{
    public class EditProfileModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]  
        public string Email { get; set; }
        [Required]  
        public string Number { get; set; }

        [Required]
        public string Password { get; set; }


        public byte[] ProfileImage { get; set; }
    }
}
