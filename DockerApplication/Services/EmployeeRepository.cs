using DockerApplication.Models;
using DockerApplication.DAL;
namespace DockerApplication.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeDbContext context;
        public EmployeeRepository(EmployeeDbContext _context)
        {
            context = _context;
        }
        public int CreateEmployee(Employee emp)
        {
            context.Add(emp);
           return context.SaveChanges();
        }

        public IEnumerable<Employee> GetEmployeeDetails()
        {
          return context.Employee.ToList();
        }
    }
}