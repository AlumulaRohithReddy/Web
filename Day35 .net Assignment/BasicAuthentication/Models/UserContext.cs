using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace BasicAuthentication.Models
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
       
    }
}
