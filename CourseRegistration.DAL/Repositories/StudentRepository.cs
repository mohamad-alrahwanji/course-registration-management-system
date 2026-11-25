using CourseRegistration.Entities;
using CourseRegistration.DAL.DataProviders;


namespace CourseRegistration.DAL.Repositories
{
    public class StudentRepository : RepositoryBase<Student>
    {
        public List<Student> GetAll() => StudentDataProvider.GetAll();

        public bool Add(User user, Student student) => StudentDataProvider.Add(user, student);

        public bool UsernameExists(string username) => StudentDataProvider.UsernameExists(username);

        public bool StudentNumberExists(string studentNumber) => StudentDataProvider.StudentNumberExists(studentNumber);

        public bool EmailExists(string email) => StudentDataProvider.EmailExists(email);

        public List<Student> Search(string searchText) => StudentDataProvider.Search(searchText);

        public bool Delete(int studentId, int userId) => StudentDataProvider.Delete(studentId, userId);

        public bool Edit(User user, Student student, bool passwordChanged) => StudentDataProvider.Edit(user, student, passwordChanged);

        public bool UsernameExists(string username, int excludedId) => StudentDataProvider.UsernameExists(username, excludedId);

        public bool StudentNumberExists(string studentNumber, int excludedId) => StudentDataProvider.StudentNumberExists(studentNumber, excludedId);

        public bool EmailExists(string email, int excludedId) => StudentDataProvider.EmailExists(email, excludedId);

        public Student GetByUserId(int userId) => StudentDataProvider.GetByUserId(userId);

        public bool UpdateStudentProfile(Student student, string? passwordHash) => StudentDataProvider.UpdateStudentProfile(student, passwordHash);
    }
}
