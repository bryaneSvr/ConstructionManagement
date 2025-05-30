using AccessManagement.Data;
using AccessManagement.Models;

namespace AccessManagement.Test
{
    public static class EmployeeDataSetup
    {
        public static List<Employee> Employees =
        [
            new Employee
            {
                Address = "123",
                Name = "123",
                Id = 1,
                ContactNumber = "1234567890",
                Country = "Country1"
            }
        ];


        public static List<EmployeeData> EmployeeData =
        [
            new EmployeeData
            {
                Address = "123",
                Name = "123",
                ContactNumber = "1234567890",
                Country = "Country1"
            }
        ];

        public static IEnumerable<long> EmployeeIds = [1, 2];
    }
}
