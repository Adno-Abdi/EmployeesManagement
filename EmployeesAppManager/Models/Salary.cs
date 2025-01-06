namespace EmployeesAppManager.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public String? PayWay { get; set; }
        public DateTime PayDate { get; set; }
        public int EmployeeId { get; set; }
        public Employees? Employees { get; set; }
    }
}
