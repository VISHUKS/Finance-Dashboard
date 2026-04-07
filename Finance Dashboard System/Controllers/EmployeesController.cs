using Finance_Dashboard_System.Interfaces;
using Finance_Dashboard_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Finance_Dashboard_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // POST api/<EmployeesController>
        [HttpPost("AddEmployee")]
        [Authorize(Roles = "Admin")]
        public Employee AddEmployee([FromBody] Employee emp)
        {
            var employee = _employeeService.AddEmployee(emp);
            return employee;
        }


        // GET: api/<EmployeesController>
        [HttpGet("GetEmployees")]
        [Authorize(Roles = "Viewer,Analyst,Admin,HR")]
        public List<Employee> GetEmployees()
        {
            return _employeeService.GetEmployeeDetails();
        }
    }
}
