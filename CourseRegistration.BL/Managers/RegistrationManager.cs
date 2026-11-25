using CourseRegistration.Entities;
using CourseRegistration.DAL.Repositories;
using CourseRegistration.BL.Helpers;

namespace CourseRegistration.BL.Managers
{
    internal class RegistrationManager
    {
        private readonly RegistrationRepository _registrationRepository;
        private readonly ClassRepository _classRepository;

        internal RegistrationManager()
        {
            _registrationRepository = new RegistrationRepository();
            _classRepository = new ClassRepository();
        }

        internal bool Add(Registration registration)
        {
            if (_registrationRepository.Exists(registration.StudentId, registration.ClassId))
                throw new ArgumentException("You are already registered for this class.");

            if (_registrationRepository.HasActiveRegistrationInCourse(registration.StudentId, registration.ClassId))
                throw new ArgumentException("You are already registered in another class for this course.");

            List<Registration> activeRegistrations = _registrationRepository.GetActiveByStudentId(registration.StudentId);

            foreach (Registration activeRegistration in activeRegistrations)
            {
                if (ScheduleHelper.SchedulesOverlap(registration.Schedule, activeRegistration.Schedule))
                    throw new ArgumentException("This class overlaps with another class in your schedule.");
            }

            if (!_classRepository.IsAvailable(registration.ClassId)) throw new ArgumentException("Class is no longer available.");

            registration.RegistrationDate = DateTime.Now;
            registration.Status = "Active";

            return _registrationRepository.Add(registration);
        }

        internal List<Registration> GetByStudentId(int studentId)
        {
            return _registrationRepository.GetByStudentId(studentId);
        }

        internal bool Cancel(int registrationId)
        {
            return _registrationRepository.Cancel(registrationId);
        }

        internal List<Registration> GetActiveByStudentId(int studentId)
        {
            return _registrationRepository.GetActiveByStudentId(studentId);
        }

        internal List<RegistrationReport> GetByClassId(int classId)
        {
            return _registrationRepository.GetByClassId(classId);
        }
    }
}
