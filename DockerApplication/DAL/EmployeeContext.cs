using Microsoft.EntityFrameworkCore;
using DockerApplication.Models;
namespace DockerApplication.DAL
{
public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions dbContextOptions) : base (dbContextOptions)   // Constructor chaning
        {
            
        }

        public DbSet<Employee> Employee {get;set;}
    }
}

