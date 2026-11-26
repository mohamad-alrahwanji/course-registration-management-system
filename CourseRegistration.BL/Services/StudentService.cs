using CourseRegistration.BL.Managers;
using CourseRegistration.Entities;

namespace CourseRegistration.BL.Services
{
    public static class StudentService
    {
        private readonly static StudentManager _manager = new StudentManager();

        public static List<Student> GetAll() => _manager.GetAll();

        public static bool Add(User user, Student student, string password, string confirmedPassword) 
            => _manager.Add(user, student, password, confirmedPassword);

        public static List<Student> Search(string searchText) => _manager.Search(searchText);

        public static bool Delete(Student student) => _manager.Delete(student);

        public static bool Edit(Student student, User user, string newPassword) => _manager.Edit(student, user, newPassword);

        public static Student GetByUserId(int userId) => _manager.GetByUserId(userId);

        public static bool UpdateStudentProfile(Student student, string newPassword) => _manager.UpdateStudentProfile(student, newPassword);
    }
}
