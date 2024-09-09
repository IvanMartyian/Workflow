using Microsoft.EntityFrameworkCore;
using Employees.Models;

namespace Employees.Data
{
    public class EmployeeDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public EmployeeDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("EmployeeDB"));
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .ToTable("Employee");

            modelBuilder.Entity<Employee>()
                .HasData(
                    new Employee { Id = 1, FirstName = "Max", LastName = "Muster", BirthDate = new DateTime(1980, 1, 1), Street = "Musterstraße 1", City = "Musterstadt", PostalCode = "12345" },
                    new Employee { Id = 2, FirstName = "Erika", LastName = "Mustermann", BirthDate = new DateTime(1990, 2, 2), Street = "Beispielweg 2", City = "Beispielstadt", PostalCode = "67890" }
                );
        }
    }
}