namespace CourseRegistration.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public int CreditHours { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

    }
}   
