namespace EmployeesAppManager.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int projectId { get; set; }
        public Projects? Projects { get; set; }
    }
}
