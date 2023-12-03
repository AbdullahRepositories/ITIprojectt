using Microsoft.EntityFrameworkCore;

namespace ITIproject.Models
{
    public class ITIEntities:DbContext
    {
        public ITIEntities():base()
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-105BV8L\\LASTDB;Initial Catalog=ITIDB;Integrated Security=True");
        }
    }
}
