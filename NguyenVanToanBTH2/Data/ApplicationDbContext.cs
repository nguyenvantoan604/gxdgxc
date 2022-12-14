using NguyenVanToanBTH2.Models;
using Microsoft.EntityFrameworkCore;


namespace NguyenVanToanBTH2.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
