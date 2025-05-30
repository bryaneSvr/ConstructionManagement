namespace AccessManagement.Data
{
    /// <summary>
    /// Represents one specific Employee
    /// </summary>
    public class EmployeeData
    {
        /// <summary>
        /// Employee Name
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// Employee Address
        /// </summary>
        public required string Address { get; set; }
        /// <summary>
        /// Employee contact number
        /// </summary>
        public required string ContactNumber { get; set; }
        /// <summary>
        /// Employee country
        /// </summary>
        public required string Country { get; set; }
    }
}
