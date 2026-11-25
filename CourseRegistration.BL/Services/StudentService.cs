using CourseRegistration.BL.Managers;
using CourseRegistration.Entities;

namespace CourseRegistration.BL.Services
{
    public static class StudentService
    {
        public static List<Student> GetAll() => new StudentManager().GetAll();

        public static bool Add(User user, Student student, string password, string confirmedPassword) 
            => new StudentManager().Add(user, student, password, confirmedPassword);

        public static List<Student> Search(string searchText) => new StudentManager().Search(searchText);

        public static bool Delete(Student student) => new StudentManager().Delete(student);

        public static bool Edit(Student student, User user, string newPassword) => new StudentManager().Edit(student, user, newPassword);

        public static Student GetByUserId(int userId) => new StudentManager().GetByUserId(userId);

        public static bool UpdateStudentProfile(Student student, string newPassword) => new StudentManager().UpdateStudentProfile(student, newPassword);
    }
}
