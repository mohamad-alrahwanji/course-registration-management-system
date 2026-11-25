using CourseRegistration.DAL.DataProviders;
using CourseRegistration.Entities;


namespace CourseRegistration.DAL.Repositories
{
    public class RegistrationRepository : RepositoryBase<Registration>
    {
        public bool Add(Registration registration) => RegistrationDataProvider.Add(registration);

        public List<Registration> GetByStudentId(int studentId) => RegistrationDataProvider.GetByStudentId(studentId);

        public bool Exists(int studentId, int classId) => RegistrationDataProvider.Exists(studentId, classId);

        public bool Cancel(int registrationId) => RegistrationDataProvider.Cancel(registrationId);

        public List<Registration> GetActiveByStudentId(int studentId) => RegistrationDataProvider.GetActiveByStudentId(studentId);

        public List<RegistrationReport> GetByClassId(int classId) => RegistrationDataProvider.GetByClassId(classId);

        public bool HasActiveRegistrationInCourse(int studentId, int classId) => RegistrationDataProvider.HasActiveRegistrationInCourse(studentId, classId);  
    }
}
