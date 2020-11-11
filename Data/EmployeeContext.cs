using EmployedCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployedCRUD.Data
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}