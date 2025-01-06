namespace EmployeesAppManager.Models
{
    public class Performance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employees? employees { get; set; }
        public double score { get; set; }
        public string? Comments { get; set; }
        public DateTime? Date { get; set; }
    }
}
