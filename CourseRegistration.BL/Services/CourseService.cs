using CourseRegistration.BL.Managers;
using CourseRegistration.Entities;

namespace CourseRegistration.BL.Services
{
    public static class CourseService
    {
        public static List<Course> GetAll() => new CourseManager().GetAll();

        public static bool Add(Course course) => new CourseManager().Add(course);

        public static bool Delete(Course course) => new CourseManager().Delete(course);

        public static bool Edit(Course course) => new CourseManager().Edit(course);

        public static List<Course> Search(string searchText) => new CourseManager().Search(searchText);
    }
}
