namespace EmployeesAppManager.Models
{
    public class Positions
    {
        public int Id { get; set; }
        public String? Title { get; set; }
        public ICollection<Employees>? Employees { get; set; }
    }
}
