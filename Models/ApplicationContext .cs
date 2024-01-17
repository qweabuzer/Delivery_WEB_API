using Microsoft.EntityFrameworkCore;

namespace DeliveryApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Orders> Orders { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    }
}
