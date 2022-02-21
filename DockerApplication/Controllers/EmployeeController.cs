using DockerApplication.Models;
using DockerApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace DockerApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        IEmployeeRepository _emprepo;
        public EmployeeController(IEmployeeRepository emprepo)
        {
            _emprepo = emprepo;
        }

        [HttpGet]
        public IActionResult GetEmployeeDetails()
        {
            return Ok(_emprepo.GetEmployeeDetails());
        }

        [HttpPost]
        public int SaveEmployee(Employee emp)   // Why are we exposing the Entity class at Controller level ?
        {                                       // Solution : AutoMapper
            return _emprepo.CreateEmployee(emp);
        }
    }
}
