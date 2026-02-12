using System.ComponentModel.DataAnnotations;
namespace ProductsWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = null!;

        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}