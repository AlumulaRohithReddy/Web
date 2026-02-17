using System.ComponentModel.DataAnnotations;

namespace WebApiDb.Models
{
    public class Claims
    {
        [Key]
        public int ClaimId { get; set; }

        public decimal ClaimAmount { get; set; }

        public string Status { get; set; }

        [Required]
        public int PolicyId { get; set; }
    }
}
