using DockerApplication.Models;

namespace DockerApplication.Services
{
    public interface IEmployeeRepository
    {
            
        int CreateEmployee(Employee emp);

        IEnumerable<Employee> GetEmployeeDetails();

    }
    }

