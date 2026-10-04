namespace CourseRegistration.Models
{
    public class Class
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string CourseCode { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string Instructor { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public int RegisteredCount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Schedule { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
