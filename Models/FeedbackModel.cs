using System.ComponentModel.DataAnnotations;

namespace MRV_resturant.Models
{
    public class FeedbackModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Complain of Waiter")]
        public string Complain { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        public string Message { get; set; }

    }
}

