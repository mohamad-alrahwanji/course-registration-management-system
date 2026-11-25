using CourseRegistration.Entities;
using CourseRegistration.DAL.DataProviders;

namespace CourseRegistration.DAL.Repositories
{
    public class ClassRepository : RepositoryBase<Class>
    {
        public List<Class> GetAll()
        {
            return ClassDataProvider.GetAll();
        }

        public bool Add(Class courseClass)
        {
            return ClassDataProvider.Add(courseClass);
        }

        public bool Delete(int classId)
        {
            return ClassDataProvider.Delete(classId);
        }

        public bool Edit(Class courseClass)
        {
            return ClassDataProvider.Edit(courseClass);
        }

        public List<Class> Search(string searchText)
        {
            return ClassDataProvider.Search(searchText);
        }

        public List<Class> GetActive()
        {
            return ClassDataProvider.GetActive();
        }

        public bool IsAvailable(int classId)
        {
            return ClassDataProvider.IsAvailable(classId);
        }

        public List<Class> SearchActive(string searchText)
        {
            return ClassDataProvider.SearchActive(searchText);
        }

        public List<Class> GetByCourseId(int courseId)
        {
            return ClassDataProvider.GetByCourseId(courseId);
        }

        public string GetSchedule(int classId)
        {
            return ClassDataProvider.GetSchedule(classId);
        }
    }
}
