using CourseRegistration.BL.Managers;
using CourseRegistration.Entities;

namespace CourseRegistration.BL.Services
{
    public static class ClassService
    {
        private readonly static ClassManager _manager = new ClassManager();

        public static List<Class> GetAll() => _manager.GetAll();

        public static bool Add(Class courseClass) => _manager.Add(courseClass);

        public static bool Delete(Class courseClass) => _manager.Delete(courseClass);

        public static bool Edit(Class courseClass) => _manager.Edit(courseClass);

        public static List<Class> Search(string searchText) => _manager.Search(searchText);

        public static List<Class> GetActive() => _manager.GetActive();

        public static bool IsAvailable(int classId) => _manager.IsAvailable(classId);

        public static List<Class> SearchActive(string searchText) => _manager.SearchActive(searchText);

        public static List<Class> GetByCourseId(int courseId) => _manager.GetByCourseId(courseId);

    }
}
