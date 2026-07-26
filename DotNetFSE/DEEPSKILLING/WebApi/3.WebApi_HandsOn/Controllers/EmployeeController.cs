using Microsoft.AspNetCore.Mvc;
using _3.WebApi_HandsOn.Models;
using _3.WebApi_HandsOn.Filters;

namespace _3.WebApi_HandsOn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    [CustomExceptionFilter]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
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
                        new Skill
                        {
                            Id = 1,
                            Name = "C#"
                        },
                        new Skill
                        {
                            Id = 2,
                            Name = ".NET"
                        }
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
                        new Skill
                        {
                            Id = 3,
                            Name = "Communication"
                        },
                        new Skill
                        {
                            Id = 4,
                            Name = "Recruitment"
                        }
                    },
                    DateOfBirth = new DateTime(1999, 8, 15)
                }
            };
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(GetStandardEmployeeList());
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            return Ok(employee);
        }

        [HttpPut]
        public ActionResult<Employee> Put([FromBody] Employee employee)
        {
            return Ok(employee);
        }

        [HttpGet("exception")]
        public IActionResult ExceptionDemo()
        {
            throw new Exception("This is a sample exception.");
        }
    }
}