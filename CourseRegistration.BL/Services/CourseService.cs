using CourseRegistration.BL.Managers;
using CourseRegistration.Entities;

namespace CourseRegistration.BL.Services
{
    public static class CourseService
    {
        private readonly static CourseManager _manager = new CourseManager();

        public static List<Course> GetAll() => _manager.GetAll();

        public static bool Add(Course course) => _manager.Add(course);

        public static bool Delete(Course course) => _manager.Delete(course);

        public static bool Edit(Course course) => _manager.Edit(course);

        public static List<Course> Search(string searchText) => _manager.Search(searchText);
    }
}
