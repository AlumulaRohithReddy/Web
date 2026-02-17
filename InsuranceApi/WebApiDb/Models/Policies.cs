using System.ComponentModel.DataAnnotations;

namespace WebApiDb.Models
{
    public class Policies
    {
        [Key]
        public int PolicyId { get; set; }

        [Required]
        public string PolicyName { get; set; }

        public decimal Premium { get; set; }

        [Required]
        public int AgentId { get; set; }

        [Required]
        public int CustomerId { get; set; }
    }
}
