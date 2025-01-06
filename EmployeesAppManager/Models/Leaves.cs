namespace EmployeesAppManager.Models
{
    public class Leaves
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public String? Reason { get; set; }
        public string? Status { get; set; }
        public ICollection<Employees>? Employees { get; set; }
    }
}
