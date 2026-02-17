namespace BasicAuthentication.Models
{
    public class User
    {
        public int userId { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; } = true;
        public DateTime createdAt { get; set; }= DateTime.Now;


    }
}
