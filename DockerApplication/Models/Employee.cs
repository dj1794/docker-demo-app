using System.ComponentModel.DataAnnotations;
namespace DockerApplication.Models
{
    public class Employee
{
    [Key]
    public int id { get; set; }
    public string   EmpName { get; set; }
    public int EmpAge { get; set; }
}

    
}
