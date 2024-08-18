using Microsoft.EntityFrameworkCore;

namespace Exam_Pactice_18_8_24.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Exprience> Expriences { get; set; }
    }
}
