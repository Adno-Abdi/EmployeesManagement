namespace EmployeesAppManager.Models
{
    public class Employees
    {

        public int Id { get; set; }
        public String? Name { get; set; }
        public String? Address { get; set; }
        public String? Email { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public String? Degree { get; set; }
        public string? PhoneNumber { get; set; } = null;
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public Departments? Departments { get; set; }
        public Positions? Positions { get; set; }
    }
}
