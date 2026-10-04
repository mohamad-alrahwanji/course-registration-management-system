using CourseRegistration.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using CourseRegistration.Models;
using System.ComponentModel.Design;

namespace CourseRegistration.BusinessLogic
{
    public class RegistrationService
    {
        private readonly RegistrationRepository _registrationRepository;
        private readonly ClassRepository _classRepository;

        public RegistrationService(RegistrationRepository registrationRepository, ClassRepository classRepository)
        {
            _registrationRepository = registrationRepository;
            _classRepository = classRepository;
        }

        public bool Add(Registration registration)
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

        public List<Registration> GetByStudentId(int studentId)
        {
            return _registrationRepository.GetByStudentId(studentId);
        }

        public bool Cancel(int registrationId)
        {
            return _registrationRepository.Cancel(registrationId);
        }

        public List<Registration> GetActiveByStudentId(int studentId)
        {
            return _registrationRepository.GetActiveByStudentId(studentId);
        }

        public List<RegistrationReport> GetByClassId(int classId)
        {
            return _registrationRepository.GetByClassId(classId);
        }
    }
}
