using Microsoft.EntityFrameworkCore;
using DemoMVC.Models.Student;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor bắt buộc
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Khai báo bảng trong database
        public DbSet<Student> Students { get; set; }
    }
}