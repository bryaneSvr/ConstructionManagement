using AccessManagement.Data;
using AccessManagement.Models;

namespace AccessManagement.Interfaces;

public interface IEmployeeService
{
    Task<List<Employee>> GetEmployees(string EmployeeName);
    string InsertEmployees(IEnumerable<EmployeeData> Employees);
    string UpdateEmployees(IEnumerable<Employee> Employees);
    string DeleteEmployees(IEnumerable<long> EmployeeIds);
}
