namespace EmployeesAppManager.Models
{
    public class Attendance
    {

        public int Id { get; set; }
        public bool Present { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeId { get; set; }
        public ICollection<Employees>? Employees { get; set; }
    }
}
