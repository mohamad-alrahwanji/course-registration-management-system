using CourseRegistration.DataAccess;
using CourseRegistration.Models;
using System.Text.RegularExpressions;

namespace CourseRegistration.BusinessLogic
{
    public class CourseService
    {
        private readonly CourseRepository _courseRepository;

        public CourseService(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public List<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public bool Add(Course course)
        {
            bool isCourseCodeValid = Regex.IsMatch(course.CourseCode, @"^[A-Z]{2}[0-9]{3}$");

            if (course == null) throw new ArgumentNullException(nameof(course));
            if (!isCourseCodeValid) throw new ArgumentException("Course code format must be 2 uppercase letters followed by 3 digits.");
            if (course.CourseName == null) throw new ArgumentException("Course name cannot be null.");
            if (course.CreditHours < 0 || course.CreditHours > 15) throw new ArgumentException("Credit Hours must be between 0 and 15.");
            if (course.CourseName.Length > 100) throw new ArgumentException("Course name cannot exceed 100 characters.");
            if (course.Description?.Length > 255) throw new ArgumentException("Description cannot exceed 255 characters.");
            if (_courseRepository.CourseCodeExists(course.CourseCode)) throw new ArgumentException($"Course code {course.CourseCode} already exists.");
            if (_courseRepository.CourseNameExists(course.CourseName)) throw new ArgumentException($"Course name {course.CourseName} already exists.");

            return _courseRepository.Add(course);
        }

        public bool Delete(Course course)
        {
            return _courseRepository.Delete(course.Id);
        }

        public bool Edit(Course course)
        {
            bool isCourseCodeValid = Regex.IsMatch(course.CourseCode, @"^[A-Z]{2}[0-9]{3}$");

            if (!isCourseCodeValid) throw new ArgumentException("Course code format must be 2 uppercase letters followed by 3 digits.");
            if (course.CreditHours < 0 || course.CreditHours > 15) throw new ArgumentException("Credit Hours must be between 0 and 15.");
            if (course.CourseName.Length > 100) throw new ArgumentException("Course name cannot exceed 100 characters.");
            if (course.Description?.Length > 255) throw new ArgumentException("Description cannot exceed 255 characters.");
            if (_courseRepository.CourseCodeExists(course.CourseCode, course.Id)) throw new ArgumentException($"Course code {course.CourseCode} already exists.");
            if (_courseRepository.CourseNameExists(course.CourseName, course.Id)) throw new ArgumentException($"Course name {course.CourseName} already exists.");

            return _courseRepository.Edit(course);
        }

        public List<Course> Search(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) return GetAll();
            return _courseRepository.Search(searchText.Trim());
        }

    }
}