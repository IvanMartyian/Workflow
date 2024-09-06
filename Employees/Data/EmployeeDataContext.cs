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
                // Hier kannst du Seed-Daten hinzufügen, falls gewünscht
                );
        }
    }
}