using Microsoft.EntityFrameworkCore;

namespace RabitMqProductAPI.Model
{

    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
