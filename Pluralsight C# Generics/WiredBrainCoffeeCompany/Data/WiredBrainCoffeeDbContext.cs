using Microsoft.EntityFrameworkCore;
using WiredBrainCoffeeCompany.Entites;

namespace WiredBrainCoffeeCompany.Data
{
    public class WiredBrainCoffeeDbContext : DbContext
    {
        DbSet<Employee> Employees => Set<Employee>();
        DbSet<Organization> Organizations => Set<Organization>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            options.UseInMemoryDatabase("WiredBrainCoffeeDb");
        }
    }
}