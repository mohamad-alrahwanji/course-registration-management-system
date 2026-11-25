using CourseRegistration.Entities;
using CourseRegistration.DAL.Repositories;
using CourseRegistration.BL.Helpers;

namespace CourseRegistration.BL.Managers
{
    internal class ClassManager
    {
        private readonly ClassRepository _classRepository;
        internal ClassManager()
        {
            _classRepository = new ClassRepository();
        }
        
        internal List<Class> GetAll()
        {
            return _classRepository.GetAll();
        }

        internal bool Add(Class courseClass)
        {
            if (string.IsNullOrWhiteSpace(courseClass.ClassName)) throw new ArgumentException("Class name can not be empty.");
            if (courseClass.ClassName.Length > 50) throw new ArgumentException("Class name can not exceed 50 characters.");
            if (string.IsNullOrWhiteSpace(courseClass.Instructor)) throw new ArgumentException("Instructor can not be empty.");
            if (courseClass.Instructor.Length > 50) throw new ArgumentException("Instructor can not exceed 50 characters.");
            if (courseClass.Capacity <= 0) throw new ArgumentException("Capacity can not be negative.");
            if (courseClass.StartDate >= courseClass.EndDate) throw new ArgumentException("Start Date must be before End Date");
            if (string.IsNullOrWhiteSpace(courseClass.Schedule)) throw new ArgumentException("Schedule can not be empty.");

            List<Class> classes = _classRepository.GetAll();

            foreach (Class existingClass in classes)
            {
                bool sameInstructor = existingClass.Instructor.ToLower() == courseClass.Instructor.ToLower();

                bool datesOverlap = courseClass.StartDate <= existingClass.EndDate && courseClass.EndDate >= existingClass.StartDate;

                if (courseClass.IsActive && existingClass.IsActive && sameInstructor && datesOverlap
                    && ScheduleHelper.SchedulesOverlap(courseClass.Schedule, existingClass.Schedule))
                    throw new ArgumentException("This instructor already has another class at this time.");
            }

            return _classRepository.Add(courseClass);
        }

        internal bool Delete(Class courseClass)
        {
            return _classRepository.Delete(courseClass.Id);
        }

        internal bool Edit(Class courseClass)
        {
            if (string.IsNullOrWhiteSpace(courseClass.ClassName)) throw new ArgumentException("Class name can not be empty.");
            if (courseClass.ClassName.Length > 50) throw new ArgumentException("Class name can not exceed 50 characters.");
            if (string.IsNullOrWhiteSpace(courseClass.Instructor)) throw new ArgumentException("Instructor can not be empty.");
            if (courseClass.Instructor.Length > 50) throw new ArgumentException("Instructor can not exceed 50 characters.");
            if (courseClass.Capacity <= 0) throw new ArgumentException("Capacity can not be negative.");
            if (courseClass.StartDate >= courseClass.EndDate) throw new ArgumentException("Start Date must be before End Date");
            if (string.IsNullOrWhiteSpace(courseClass.Schedule)) throw new ArgumentException("Schedule can not be empty.");

            List<Class> classes = _classRepository.GetAll();

            foreach (Class existingClass in classes)
            {
                if (existingClass.Id == courseClass.Id) continue;
                
                bool sameInstructor = existingClass.Instructor.ToLower() == courseClass.Instructor.ToLower();

                bool datesOverlap = courseClass.StartDate <= existingClass.EndDate && courseClass.EndDate >= existingClass.StartDate;

                if (courseClass.IsActive && existingClass.IsActive && sameInstructor && datesOverlap
                    && ScheduleHelper.SchedulesOverlap(courseClass.Schedule, existingClass.Schedule))
                    throw new ArgumentException("This instructor already has another class at this time.");
            }

            return _classRepository.Edit(courseClass);
        }

        internal List<Class> Search(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) return GetAll();

            return _classRepository.Search(searchText.Trim());
        }

        internal List<Class> GetActive()
        {
            return _classRepository.GetActive();
        }

        internal bool IsAvailable(int classId)
        {
            return _classRepository.IsAvailable(classId);
        }

        internal List<Class> SearchActive(string searchText)
        {
            if(string.IsNullOrWhiteSpace(searchText)) return GetActive();

            return _classRepository.SearchActive(searchText.Trim());
        }

        internal List<Class> GetByCourseId(int courseId)
        {
            return _classRepository.GetByCourseId(courseId);
        }
    }
}
