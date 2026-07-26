using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using _5.WebApi_HandsOn.Models;

namespace _5.WebApi_HandsOn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 50000,
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
                DateOfBirth = new DateTime(1998,5,10)
            },
            new Employee
            {
                Id = 2,
                Name = "David",
                Salary = 60000,
                Permanent = false,
                Department = new Department
                {
                    Id = 2,
                    Name = "HR"
                },
                Skills = new List<Skill>
                {
                    new Skill { Id = 3, Name = "SQL" }
                },
                DateOfBirth = new DateTime(1999,8,20)
            }
        };

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Employee employee)
        {
            var existing = employees.FirstOrDefault(e => e.Id == id);

            if (existing == null)
                return NotFound();

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
                return NotFound();

            employees.Remove(employee);

            return Ok("Employee Deleted Successfully");
        }
    }
}