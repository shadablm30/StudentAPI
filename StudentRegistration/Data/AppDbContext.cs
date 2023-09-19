using Microsoft.EntityFrameworkCore;
using StudentRegistration.Models;

namespace StudentRegistration.Data
{
    public class AppDbContext :  DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
