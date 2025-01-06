namespace EmployeesAppManager.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public ICollection<Employees>? Employees { get; set; }
    }
}
