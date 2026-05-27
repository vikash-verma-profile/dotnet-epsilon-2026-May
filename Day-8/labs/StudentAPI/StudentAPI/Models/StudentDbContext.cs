using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext()
        {
                
        }
        public StudentDbContext(DbContextOptions<StudentDbContext> option):base(option)
        {
                
        }

        public DbSet<Student> Students { get; set; }
     
    }
}
