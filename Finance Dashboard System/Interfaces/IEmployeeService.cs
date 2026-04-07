using Finance_Dashboard_System.Models;

namespace Finance_Dashboard_System.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeeDetails();
        public Employee AddEmployee(Employee employee);
    }
}
