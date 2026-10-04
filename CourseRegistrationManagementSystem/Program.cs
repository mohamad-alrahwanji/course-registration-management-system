using CourseRegistration.BusinessLogic;
using CourseRegistration.DataAccess;
using Microsoft.AspNetCore.Identity;
using CourseRegistration.Models;

namespace CourseRegistrationManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Server=localhost;Database=CourseRegistrationDB;Integrated Security=True;TrustServerCertificate=True;";

            CourseRepository courseRepository = new CourseRepository(connectionString);
            CourseService courseService = new CourseService(courseRepository);

            UserRepository userRepository = new UserRepository(connectionString);
            UserService userService = new UserService(userRepository);

            StudentRepository studentRepository = new StudentRepository(connectionString);
            StudentService studentService = new StudentService(studentRepository);

            ClassRepository classRepository = new ClassRepository(connectionString);
            ClassService classService = new ClassService(classRepository);

            RegistrationRepository registrationRepository = new RegistrationRepository(connectionString);
            RegistrationService registrationService = new RegistrationService(registrationRepository, classRepository);

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(userService, courseService, studentService, classService, registrationService));
        }
    }
}