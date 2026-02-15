using System.ComponentModel.DataAnnotations;

namespace InsuranceWebApi.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<Policies>? Policies { get; set; }
        public ICollection<Claims>? Claims { get; set; }


    }
}
