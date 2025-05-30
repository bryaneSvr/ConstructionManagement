using Autofac.Extras.Moq;
using AccessManagement.Data;
using AccessManagement.Services;

namespace AccessManagement.Test;

public class AccessManagementTest
{
    [Fact]
    public void GetEmployees_Test()
    {
        using (var mock = AutoMock.GetLoose())
        {
            mock.Mock<IDataAccess>()
                .Setup(x => x.GetEmployees(string.Empty))
                .Returns(EmployeeDataSetup.Employees);

            var cls = mock.Create<EmployeeService>();

            var expected = EmployeeDataSetup.Employees;
            var actual = cls.GetEmployees(string.Empty);

            Assert.True(actual.Result != null);
            Assert.Equal(expected.Count, actual.Result.Count);
        }
    }

    [Fact]
    public void InsertEmployees_Test()
    {
        var records = EmployeeDataSetup.EmployeeData.Count().ToString();
        using var mock = AutoMock.GetLoose(); 

        var cls = mock.Create<EmployeeService>();

        var expected = $"{records} record(s) inserted.";
        var actual = cls.InsertEmployees(EmployeeDataSetup.EmployeeData);

        Assert.Equal(actual, expected);
    }

    [Fact]
    public void UpdateEmployees_Test()
    {
        var records = EmployeeDataSetup.Employees.Count().ToString();

        using var mock = AutoMock.GetLoose(); 
        mock.Mock<IDataAccess>()
            .Setup(x => x.UpdateEmployees(EmployeeDataSetup.Employees))
            .Returns(records);

        var cls = mock.Create<EmployeeService>();

        var expected = $"{records} record(s) updated.";
        var actual = cls.UpdateEmployees(EmployeeDataSetup.Employees);

        Assert.Equal(actual, expected);
    }

    [Fact]
    public void DeleteEmployees_Test()
    {
        var records = EmployeeDataSetup.EmployeeIds.Count().ToString();

        using var mock = AutoMock.GetLoose(); 
        mock.Mock<IDataAccess>()
            .Setup(x => x.DeleteEmployees(EmployeeDataSetup.EmployeeIds))
            .Returns(EmployeeDataSetup.EmployeeIds.Count().ToString());

        var cls = mock.Create<EmployeeService>();

        var expected = $"{records} record(s) deleted.";
        var actual = cls.DeleteEmployees(EmployeeDataSetup.EmployeeIds);

        Assert.Equal(actual, expected);
    }
}