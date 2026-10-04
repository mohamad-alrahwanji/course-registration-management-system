using System;
using System.Collections.Generic;
using System.Text;
using CourseRegistration.Models;
using Microsoft.Data.SqlClient;

namespace CourseRegistration.DataAccess
{
    public class RegistrationRepository
    {
        private readonly string _connectionString;

        public RegistrationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool Add(Registration registration)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Insert Into Registrations (StudentId, ClassId, RegistrationDate, Status) " +
                "Values (@StudentId, @ClassId, @RegistrationDate, @Status)", connection);

            command.Parameters.AddWithValue("@StudentId", registration.StudentId);
            command.Parameters.AddWithValue("@ClassId", registration.ClassId);
            command.Parameters.AddWithValue("@RegistrationDate", registration.RegistrationDate);
            command.Parameters.AddWithValue("@Status", registration.Status);

            return command.ExecuteNonQuery() == 1;
        }

        public List<Registration> GetByStudentId(int studentId)
        {
            List<Registration> registrations = new List<Registration>();

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Registrations.Id, Registrations.StudentId, Registrations.ClassId, Registrations.RegistrationDate, " +
                "Registrations.Status, Courses.CourseCode, Courses.CourseName, Classes.ClassName, Classes.Schedule From Registrations Inner Join Classes On " +
                "Registrations.ClassId = Classes.Id Inner Join Courses On Classes.CourseId = Courses.Id Where Registrations.StudentId = @StudentId", 
                connection);

            command.Parameters.AddWithValue("@StudentId", studentId);

            using SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Registration registration = new Registration
                {
                    Id = (int)reader["Id"],
                    StudentId = (int)reader["StudentId"],
                    ClassId = (int)reader["ClassId"],
                    RegistrationDate = (DateTime)reader["RegistrationDate"],
                    Status = (string)reader["Status"],
                    CourseCode = (string)reader["CourseCode"],
                    CourseName = (string)reader["CourseName"],
                    ClassName = (string)reader["ClassName"],
                    Schedule = (string)reader["Schedule"]
                };

                registrations.Add(registration);
            }

            return registrations;
        }

        public bool Exists(int studentId, int classId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) From Registrations Where StudentId = @StudentId And ClassId = @ClassId " +
                "And Status = 'Active'", connection);

            command.Parameters.AddWithValue("@StudentId", studentId);
            command.Parameters.AddWithValue("@ClassId", classId);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }

        public bool Cancel(int registrationId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("UPDATE Registrations Set Status = 'Cancelled' Where Id = @Id", connection);

            command.Parameters.AddWithValue("@Id", registrationId);

            return command.ExecuteNonQuery() == 1;
        }

        public List<Registration> GetActiveByStudentId(int studentId)
        {
            List<Registration> registrations = new List<Registration>();

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Registrations.Id, Registrations.StudentId, Registrations.ClassId, Registrations.RegistrationDate, Classes.Schedule,  " +
                "Registrations.Status, Courses.CourseCode, Courses.CourseName, Classes.ClassName, Classes.Schedule From Registrations Inner Join Classes On " +
                "Registrations.ClassId = Classes.Id Inner Join Courses On Classes.CourseId = Courses.Id Where Registrations.StudentId = @StudentId " +
                "And Registrations.Status = 'Active'",connection);

            command.Parameters.AddWithValue("@StudentId", studentId);

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Registration registration = new Registration
                {
                    Id = (int)reader["Id"],
                    StudentId = (int)reader["StudentId"],
                    ClassId = (int)reader["ClassId"],
                    RegistrationDate = (DateTime)reader["RegistrationDate"],
                    Status = (string)reader["Status"],
                    CourseCode = (string)reader["CourseCode"],
                    CourseName = (string)reader["CourseName"],
                    ClassName = (string)reader["ClassName"],
                    Schedule = (string)reader["Schedule"]
                };

                registrations.Add(registration);
            }

            return registrations;
        }

        public List<RegistrationReport> GetByClassId(int classId)
        {
            List<RegistrationReport> registrations = new List<RegistrationReport>();

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Students.StudentNumber, Users.FullName, Registrations.RegistrationDate From Students Inner Join " +
                "Registrations On Students.Id = Registrations.StudentId Inner Join Users On Students.UserId = Users.Id " +
                "Where Registrations.ClassId = @ClassId And Registrations.Status = 'Active'", connection);

            command.Parameters.AddWithValue("@ClassId", classId);

            using SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                RegistrationReport registration = new RegistrationReport
                {
                    StudentName = (string)reader["FullName"],
                    StudentNumber = (string)reader["StudentNumber"],
                    RegistrationDate = (DateTime)reader["RegistrationDate"]
                };
                registrations.Add(registration);
            }
            return registrations;
        }

        public bool HasActiveRegistrationInCourse(int studentId, int classId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) From Registrations Inner Join Classes On Registrations.ClassId = Classes.Id " +
                "Where Registrations.StudentId = @StudentId And Registrations.Status = 'Active' " +
                "And Classes.CourseId = (Select CourseId From Classes Where Id = @ClassId)", connection);

            command.Parameters.AddWithValue("@StudentId", studentId);
            command.Parameters.AddWithValue("@ClassId", classId);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }
    }
}
