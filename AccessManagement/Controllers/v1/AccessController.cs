using Asp.Versioning;
using AccessManagement.Data;
using AccessManagement.Interfaces;
using AccessManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccessManagement.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class AccessController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public AccessController(IEmployeeService valuesProvider)
    {
        _employeeService = valuesProvider;
    }

    /// <summary>
    /// Gets the list of all Employees in the DB
    /// </summary>
    /// <returns>list of all Employees</returns>
    [HttpGet("employee")]
    public async Task<IEnumerable<Employee>> Get()
    {
        return await _employeeService.GetEmployees(string.Empty);
    }

    /// <summary>
    /// Gets the list of Employees with similar name
    /// </summary>
    /// <param name="EmployeeName"></param>
    [HttpGet(@"employee/{EmployeeName}")]
    public async Task<IEnumerable<Employee>> Get(string EmployeeName)
    {
        return await _employeeService.GetEmployees(EmployeeName);
    }

    /// <summary>
    /// Insert a new Employee into the DB
    /// </summary>
    /// <param name="Employees"></param>
    [HttpPost("employee")]
    public string Post([FromBody] IEnumerable<EmployeeData> Employees)
    {
        return _employeeService.InsertEmployees(Employees);
    }

    /// <summary>
    /// Update Existing Employee with provided Employee Id
    /// </summary>
    /// <param name="Employees"></param>
    [HttpPut("employee")]
    public string Put([FromBody] IEnumerable<Employee> Employees)
    {
        return _employeeService.UpdateEmployees(Employees);
    }

    /// <summary>
    /// Delete a paticular Employee
    /// </summary>
    /// <param name="EmployeeIds"></param>
    [HttpDelete("employee")]
    public string Delete(IEnumerable<long> EmployeeIds)
    {
        return _employeeService.DeleteEmployees(EmployeeIds);
    }
}
