using EmployeesAppManager.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesAppManager.Data
{
    public class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employees>Employee { get; set; }
        public DbSet<Departments> Department { get; set; }
        public DbSet<Positions> Position { get; set; }
        public DbSet<Projects> Project { get; set; }
        public DbSet<Tasks> Task { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Leaves> Leave { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<SignUp> SignUps { get; set; }
        public DbSet<SignIn> SignIns { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Call the base implementation

            //Use HasNoKey() here
            modelBuilder.Entity<SignUp>().HasNoKey();
            modelBuilder.Entity<SignIn>().HasNoKey();

        }
    }
}
