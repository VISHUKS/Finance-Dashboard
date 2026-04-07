using Finance_Dashboard_System.Context;
using Finance_Dashboard_System.Interfaces;
using Finance_Dashboard_System.Models;

namespace Finance_Dashboard_System.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JwtContext _Context;
        public EmployeeService(JwtContext context)
        {
            _Context = context;
        }

        public Employee AddEmployee(Employee employee)
        {
            var emp = _Context.Employees.Add(employee);
            _Context.SaveChanges();
            return emp.Entity;
        }

        public List<Employee> GetEmployeeDetails()
        {
            var employees = _Context.Employees.ToList();
            return employees;
        }
    }
}
