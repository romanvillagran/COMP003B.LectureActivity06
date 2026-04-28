namespace COMP003B.LectureActivity6.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        public string StudentId { get; set; }

        public int CourseId { get; set; }

        public virtual Student? Students { get; set; }
        public virtual Course?  Course { get; set; }
    }
}
