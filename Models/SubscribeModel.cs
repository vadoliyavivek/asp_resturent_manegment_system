using System.ComponentModel.DataAnnotations;

namespace MRV_resturant.Models
{
    public class SubscribeModel
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Email{ get; set; }
    }
}
