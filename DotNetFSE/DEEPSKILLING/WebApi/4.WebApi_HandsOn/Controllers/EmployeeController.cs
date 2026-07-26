using _4.WebApi_HandsOn.Models;
using _4.WebApi_HandsOn.Models;
using _4.WebApi_HandsOn.Filters;
using _4.WebApi_HandsOn.Models;
using Microsoft.AspNetCore.Mvc;

namespace _4.WebApi_HandsOn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    [CustomExceptionFilter]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 75000,
                Permanent = true,
                Department = new Department
                {
                    Id = 1,
                    Name = "IT"
                },
                Skills = new List<Skill>
                {
                    new Skill { Id = 1, Name = "C#" },
                    new Skill { Id = 2, Name = ".NET" }
                },
                DateOfBirth = new DateTime(1998, 5, 10)
            },

            new Employee
            {
                Id = 2,
                Name = "Alice",
                Salary = 65000,
                Permanent = false,
                Department = new Department
                {
                    Id = 2,
                    Name = "HR"
                },
                Skills = new List<Skill>
                {
                    new Skill { Id = 3, Name = "Communication" }
                },
                DateOfBirth = new DateTime(1999, 8, 15)
            }
        };

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existing = employees.FirstOrDefault(e => e.Id == id);

            if (existing == null)
                return BadRequest("Invalid employee id");

            existing.Name = employee.Name;
            existing.Salary = employee.Salary;
            existing.Permanent = employee.Permanent;
            existing.Department = employee.Department;
            existing.Skills = employee.Skills;
            existing.DateOfBirth = employee.DateOfBirth;

            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return BadRequest("Invalid employee id");

            employees.Remove(employee);

            return Ok("Employee deleted successfully");
        }

        [HttpGet("exception")]
        public IActionResult ExceptionDemo()
        {
            throw new Exception("This is a sample exception.");
        }
    }
}