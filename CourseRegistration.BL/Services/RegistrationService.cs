using CourseRegistration.BL.Managers;
using CourseRegistration.Entities;

namespace CourseRegistration.BL.Services
{
    public static class RegistrationService
    {
        public static bool Add(Registration registration) => new RegistrationManager().Add(registration);

        public static List<Registration> GetByStudentId(int studentId) => new RegistrationManager().GetByStudentId(studentId);

        public static bool Cancel(int registrationId) => new RegistrationManager().Cancel(registrationId);

        public static List<Registration> GetActiveByStudentId(int studentId) => new RegistrationManager().GetActiveByStudentId(studentId);

        public static List<RegistrationReport> GetByClassId(int classId) => new RegistrationManager().GetByClassId(classId);
    }
}
