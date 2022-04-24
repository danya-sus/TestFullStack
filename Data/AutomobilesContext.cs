using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AutomobilesContext : DbContext
    {
        public AutomobilesContext(DbContextOptions<AutomobilesContext> options) : base(options)
        {
        }

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Car> Car { get; set; }
    }
}