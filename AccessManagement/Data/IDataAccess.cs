using AccessManagement.Models;

namespace AccessManagement.Data
{
    public interface IDataAccess
    {
        List<Employee> GetEmployees(string AccessName);
        string InsertEmployees(IEnumerable<EmployeeData> Accesss);
        string UpdateEmployees(IEnumerable<Employee> Accesss);
        string DeleteEmployees(IEnumerable<long> AccessIds);
    }
}
