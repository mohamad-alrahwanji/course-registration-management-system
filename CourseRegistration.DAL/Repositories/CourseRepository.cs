using CourseRegistration.Entities;
using CourseRegistration.DAL.DataProviders;

namespace CourseRegistration.DAL.Repositories
{
    public class CourseRepository : RepositoryBase<Course>
    {
        public List<Course> GetAll() => CourseDataProvider.GetAll();

        public bool Add(Course course) => CourseDataProvider.Add(course);

        public bool Delete(int courseId) => CourseDataProvider.Delete(courseId);

        public bool Edit(Course course) => CourseDataProvider.Edit(course);

        public bool CourseCodeExists(string courseCode) => CourseDataProvider.CourseCodeExists(courseCode);

        public bool CourseNameExists(string courseName) => CourseDataProvider.CourseNameExists(courseName);

        public bool CourseCodeExists(string courseCode, int excludedCourseId) => CourseDataProvider.CourseCodeExists(courseCode, excludedCourseId);

        public bool CourseNameExists(string courseName, int excludedCourseId) => CourseDataProvider.CourseNameExists(courseName, excludedCourseId);

        public List<Course> Search(string searchText) => CourseDataProvider.Search(searchText);
    }
}
