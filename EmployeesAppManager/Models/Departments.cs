﻿namespace EmployeesAppManager.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public String? Description { get; set; }
        public ICollection<Employees>? Employees { get; set; }
    }
}
