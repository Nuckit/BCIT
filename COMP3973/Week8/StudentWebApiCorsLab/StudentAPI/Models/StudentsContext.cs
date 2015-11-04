using System.Data.Entity;

namespace StudentAPI.Models
{
    public class StudentsContext : DbContext
    {
        public StudentsContext() : base("DefaultConnection")
        {            
        }

        public DbSet<Student> Students { get; set; }
    }
}