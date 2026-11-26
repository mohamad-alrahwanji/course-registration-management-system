using CourseRegistration.BL.Managers;
using CourseRegistration.Entities;

namespace CourseRegistration.BL.Services
{
    public static class RegistrationService
    {
        private readonly static RegistrationManager _manager = new RegistrationManager();

        public static bool Add(Registration registration) => _manager.Add(registration);

        public static List<Registration> GetByStudentId(int studentId) => _manager.GetByStudentId(studentId);

        public static bool Cancel(int registrationId) => _manager.Cancel(registrationId);

        public static List<Registration> GetActiveByStudentId(int studentId) => _manager.GetActiveByStudentId(studentId);

        public static List<RegistrationReport> GetByClassId(int classId) => _manager.GetByClassId(classId);
    }
}
