using CourseRegistration.Models;
using Microsoft.Data.SqlClient;

namespace CourseRegistration.DataAccess
{
    public class CourseRepository
    {
        private readonly string _connectionString;

        public CourseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Course> GetAll()
        {
            List<Course> courses = new List<Course>();
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Id, CourseCode, CourseName, CreditHours, Description, IsActive From Courses", connection);
            using SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Course course = new Course
                {
                    Id = (int)reader["Id"],
                    CourseCode = (string)reader["CourseCode"],
                    CourseName = (string)reader["CourseName"],
                    CreditHours = (int)reader["CreditHours"],
                    Description = reader["Description"] == DBNull.Value ? null : (string)reader["Description"], // If it's null in DB, then assign the C# null
                    IsActive = (bool)reader["IsActive"]
                };

                courses.Add(course);
            }

            return courses;
        }

        public bool Add(Course course)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("INSERT INTO Courses (CourseCode, CourseName, CreditHours, Description, IsActive) " +
                "VALUES (@CourseCode, @CourseName, @CreditHours, @Description, @IsActive)", connection);

            command.Parameters.AddWithValue("@CourseCode", course.CourseCode);
            command.Parameters.AddWithValue("@CourseName", course.CourseName);
            command.Parameters.AddWithValue("@CreditHours", course.CreditHours);
            command.Parameters.AddWithValue("@Description", (object?)course.Description ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsActive", course.IsActive);

            int affectedRows = command.ExecuteNonQuery();

            return affectedRows == 1;

        }

        public bool CourseCodeExists(string courseCode)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            
            using SqlCommand command = new("Select Count(*) from Courses Where CourseCode = @CourseCode", connection);
            command.Parameters.AddWithValue("@CourseCode", courseCode);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }

        public bool CourseNameExists(string courseName)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) from Courses Where CourseName = @CourseName", connection);
            command.Parameters.AddWithValue("@CourseName", courseName);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }

        public bool Delete(int courseId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Delete From Courses Where Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", courseId);

            return command.ExecuteNonQuery() == 1;
        }

        public bool Edit(Course course)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Update Courses Set" +
                " CourseCode = @CourseCode, CourseName = @CourseName, CreditHours = @CreditHours, Description = @Description, IsActive = @IsActive" +
                " Where Id = @Id", connection);

            command.Parameters.AddWithValue("@CourseCode", course.CourseCode);
            command.Parameters.AddWithValue("@CourseName", course.CourseName);
            command.Parameters.AddWithValue("@CreditHours", course.CreditHours);
            command.Parameters.AddWithValue("@Description", (object?)course.Description ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsActive", course.IsActive);
            command.Parameters.AddWithValue("@Id", course.Id);

            return command.ExecuteNonQuery() == 1;
        }

        public bool CourseCodeExists(string courseCode, int excludedCourseId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) from Courses Where CourseCode = @CourseCode And Id <> @Id", connection);
            command.Parameters.AddWithValue("@CourseCode", courseCode);
            command.Parameters.AddWithValue("@Id", excludedCourseId);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }

        public bool CourseNameExists(string courseName, int excludedCourseId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) from Courses Where CourseName = @CourseName And Id <> @Id", connection);
            command.Parameters.AddWithValue("@CourseName", courseName);
            command.Parameters.AddWithValue("@Id", excludedCourseId);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }

        public List<Course> Search(string searchText)
        {
            List<Course> courses = new List<Course>();

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Id, CourseCode, CourseName, CreditHours, Description, IsActive From Courses" +
                " Where CourseName Like @Search Or CourseCode Like @Search", connection);

            command.Parameters.AddWithValue("@Search", $"%{searchText}%");

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Course course = new Course
                {
                    Id = (int)reader["Id"],
                    CourseCode = (string)reader["CourseCode"],
                    CourseName = (string)reader["CourseName"],
                    CreditHours = (int)reader["CreditHours"],
                    Description = reader["Description"] == DBNull.Value ? null : (string)reader["Description"],
                    IsActive = (bool)reader["IsActive"]
                };

                courses.Add(course);
            }

            return courses;
        }

    }
}