using AccessManagement.Data;
using AccessManagement.Interfaces;
using AccessManagement.Models;

namespace AccessManagement.Services;

public class EmployeeService : IEmployeeService
{
    public Task<List<Employee>> GetEmployees(string EmployeeName)
    {
        throw new NotImplementedException();
    }

    public string InsertEmployees(IEnumerable<EmployeeData> Employees)
    {
        throw new NotImplementedException();
    }

    public string UpdateEmployees(IEnumerable<Employee> Employees)
    {
        throw new NotImplementedException();
    }
    public string DeleteEmployees(IEnumerable<long> EmployeeIds)
    {
        throw new NotImplementedException();
    }
}
