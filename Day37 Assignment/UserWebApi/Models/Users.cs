using System.ComponentModel.DataAnnotations;

namespace UserWebApi.Models
{
    public class Users
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); 

        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
    }

}