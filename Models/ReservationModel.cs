using System.ComponentModel.DataAnnotations;

namespace MRV_resturant.Models
{
    public class ReservationModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Mobile number must be numeric")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Number of persons is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value greater than 0")]
        public int Person { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Time is required")]
        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }

        [Required(ErrorMessage = "Food selection is required")]
        public string Food { get; set; }

        public string Occasion { get; set; }
    }
}
