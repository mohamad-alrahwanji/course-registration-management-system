using CourseRegistration.BL.Managers;
using CourseRegistration.Entities;

namespace CourseRegistration.BL.Services
{
    public static class ClassService
    {
        public static List<Class> GetAll() => new ClassManager().GetAll();

        public static bool Add(Class courseClass) => new ClassManager().Add(courseClass);

        public static bool Delete(Class courseClass) => new ClassManager().Delete(courseClass);

        public static bool Edit(Class courseClass) => new ClassManager().Edit(courseClass);

        public static List<Class> Search(string searchText) => new ClassManager().Search(searchText);

        public static List<Class> GetActive() => new ClassManager().GetActive();

        public static bool IsAvailable(int classId) => new ClassManager().IsAvailable(classId);

        public static List<Class> SearchActive(string searchText) => new ClassManager().SearchActive(searchText);

        public static List<Class> GetByCourseId(int courseId) => new ClassManager().GetByCourseId(courseId);

    }
}
