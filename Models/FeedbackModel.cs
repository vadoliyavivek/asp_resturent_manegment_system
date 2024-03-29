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
        [Display(Name = "Give The Rating Between 1 to 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        [Display(Name = "Any Message For US")]
        public string Message { get; set; }

    }
}

