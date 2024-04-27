using CoderzApp204.Models;
using Microsoft.EntityFrameworkCore;

namespace CoderzApp204.Data
{
    public class CoderZDbContext : DbContext
    {

        public CoderZDbContext(DbContextOptions<CoderZDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
