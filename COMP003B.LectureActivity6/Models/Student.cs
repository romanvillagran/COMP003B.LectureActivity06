using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity6.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public virtual ICollection<Enrollment>? Enrollments { get; set; }
        public int Age { get; set; }

    }
}
