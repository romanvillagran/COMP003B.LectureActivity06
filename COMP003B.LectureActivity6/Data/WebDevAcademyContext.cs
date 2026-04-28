using COMP003B.LectureActivity6.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.LectureActivity6.Data
{
    public class WebDevAcademyContext : DbContext
    {
        public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options) { 
        }

        public DbSet<Student> students { get; set; }

        public DbSet<Course> courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
