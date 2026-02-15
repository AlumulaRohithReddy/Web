using Microsoft.EntityFrameworkCore;


namespace InsuranceWebApi.Models
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions<InsuranceContext> options)
            : base(options)
        {
        }
        public DbSet<Agents> Agents { get; set; } = null!;
        public DbSet<Customers> Customers { get; set; }= null!;

        public DbSet<Claims> Claims { get; set; }=null!;
        public DbSet<Policies> Policies { get; set; }=null !;
    }
}