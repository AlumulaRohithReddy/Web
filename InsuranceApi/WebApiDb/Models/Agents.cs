using System.ComponentModel.DataAnnotations;

namespace WebApiDb.Models
{
    public class Agents
    {
        [Key]
        public int AgentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
