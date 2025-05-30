namespace AccessManagement.Models;

/// <summary>
/// Represents one specific Employee
/// </summary>
public class Employee
{
    /// <summary>
    /// Employee Id
    /// </summary>
    public required long Id { get; set; }
    /// <summary>
    /// Employee Name
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Employee Address
    /// </summary>
    public required string Address { get; set; }
    /// <summary>
    /// Employee Contact number
    /// </summary>
    public required string ContactNumber { get; set; }
    /// <summary>
    /// Employee Country
    /// </summary>
    public required string Country { get; set; }
}
