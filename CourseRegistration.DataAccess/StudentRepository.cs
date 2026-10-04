using System;
using System.Collections.Generic;
using System.Text;
using CourseRegistration.Models;
using Microsoft.Data.SqlClient;

namespace CourseRegistration.DataAccess
{
    public class StudentRepository
    {
        private readonly string _connectionString;
        public StudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Students.Id, Students.UserId, Students.StudentNumber, Users.FullName, Users.Username, " +
                "Students.Email, Students.Phone, Users.IsActive From Students Inner Join Users On Students.UserId = Users.Id", connection);

            using SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Student student = new Student
                {
                    Id = (int)reader["Id"],
                    UserId = (int)reader["UserId"],
                    StudentNumber = (string)reader["StudentNumber"],
                    FullName = (string)reader["FullName"],
                    Email = (string)reader["Email"],
                    Phone = (string)reader["Phone"],
                    IsActive = (bool)reader["IsActive"],
                    Username = (string)reader["Username"]
                };
                students.Add(student);
            }

            return students;
        }

        public bool Add(User user, Student student)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                using SqlCommand userCommand = new("Insert Into Users (Username, PasswordHash, FullName, Role, IsActive) Output Inserted.Id " +
                    "Values (@Username, @PasswordHash, @FullName, @Role, @IsActive)", connection, transaction);

                userCommand.Parameters.AddWithValue("@Username", user.Username);
                userCommand.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                userCommand.Parameters.AddWithValue("@FullName", user.FullName);
                userCommand.Parameters.AddWithValue("@Role", user.Role);
                userCommand.Parameters.AddWithValue("@IsActive", user.IsActive);

                int userId = Convert.ToInt32(userCommand.ExecuteScalar());

                using SqlCommand studentCommand = new("Insert Into Students (UserId, StudentNumber, Email, Phone) " +
                    "Values (@UserId, @StudentNumber, @Email, @Phone)", connection, transaction);

                studentCommand.Parameters.AddWithValue("@UserId", userId);
                studentCommand.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                studentCommand.Parameters.AddWithValue("@Email", student.Email);
                studentCommand.Parameters.AddWithValue("@Phone", student.Phone);

                int affectedRows = studentCommand.ExecuteNonQuery();

                if (affectedRows != 1)
                {
                    transaction.Rollback();
                    return false;
                }

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public bool UsernameExists(string username)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) from Users Where Username = @Username", connection);
            command.Parameters.AddWithValue("@Username", username);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }
        public bool StudentNumberExists(string studentNumber)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) from Students Where StudentNumber = @StudentNumber", connection);
            command.Parameters.AddWithValue("@StudentNumber", studentNumber);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }
        public bool EmailExists(string email)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) from Students Where Email = @Email", connection);
            command.Parameters.AddWithValue("@Email", email);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }

        public List<Student> Search(string searchText)
        {
            List<Student> students = new List<Student>();

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Students.Id, Students.UserId, Students.StudentNumber, Users.FullName, Users.Username, " +
                "Students.Email, Students.Phone, Users.IsActive From Students Inner Join Users On Students.UserId = Users.Id " +
                "Where Students.StudentNumber Like @Search Or Users.FullName Like @Search Or Students.Email Like @Search " +
                "Or Students.Phone Like @Search Or Users.Username Like @Search", connection);

            command.Parameters.AddWithValue("@Search", $"%{searchText}%");
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student student = new Student
                {
                    Id = (int)reader["Id"],
                    UserId = (int)reader["UserId"],
                    StudentNumber = (string)reader["StudentNumber"],
                    FullName = (string)reader["FullName"],
                    Email = (string)reader["Email"],
                    Phone = (string)reader["Phone"],
                    IsActive = (bool)reader["IsActive"],
                    Username = (string)reader["Username"]
                };
                students.Add(student);
            }

            return students;
        }

        public bool Delete(int studentId, int userId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                using SqlCommand registrationCommand = new("Delete From Registrations Where StudentId = @StudentId", connection, transaction);

                registrationCommand.Parameters.AddWithValue("@StudentId", studentId);

                registrationCommand.ExecuteNonQuery();

                using SqlCommand studentCommand = new("Delete From Students Where Id = @StudentId And UserId = @UserId", connection, transaction);

                studentCommand.Parameters.AddWithValue("@StudentId", studentId);
                studentCommand.Parameters.AddWithValue("@UserId", userId);

                int studentDeleted = studentCommand.ExecuteNonQuery();

                if (studentDeleted != 1)
                {
                    transaction.Rollback();
                    return false;
                }

                using SqlCommand userCommand = new("Delete From Users Where Id = @UserId", connection, transaction);

                userCommand.Parameters.AddWithValue("@UserId", userId);

                int userDeleted = userCommand.ExecuteNonQuery();

                if(userDeleted != 1)
                {
                    transaction.Rollback();
                    return false;
                }

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }

        }

        public bool Edit(User user, Student student, bool passwordChanged)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                using SqlCommand studentCommand = new("Update Students Set UserId = @UserId, StudentNumber = @StudentNumber, Email = @Email, Phone = @Phone " +
                    "Where Id = @Id And UserId = @UserId", connection, transaction);

                studentCommand.Parameters.AddWithValue("@UserId", student.UserId);
                studentCommand.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                studentCommand.Parameters.AddWithValue("@Email", student.Email);
                studentCommand.Parameters.AddWithValue("@Phone", student.Phone);
                studentCommand.Parameters.AddWithValue("@Id", student.Id);

                bool studentEdited = studentCommand.ExecuteNonQuery() == 1;

                if(!studentEdited)
                {
                    transaction.Rollback();
                    return false;
                }

                string userSql = "Update Users Set Username = @Username, FullName = @FullName, Role = @Role, IsActive = @IsActive";

                if(passwordChanged)
                {
                    userSql += ", PasswordHash = @PasswordHash";
                }

                userSql += " Where Id = @Id";

                using SqlCommand userCommand = new(userSql, connection, transaction);

                userCommand.Parameters.AddWithValue("@Username", user.Username);
                userCommand.Parameters.AddWithValue("@FullName", user.FullName);
                userCommand.Parameters.AddWithValue("@Role", user.Role);
                userCommand.Parameters.AddWithValue("@IsActive", user.IsActive);
                userCommand.Parameters.AddWithValue("@Id", student.UserId);

                if(passwordChanged)
                {
                    userCommand.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                }

                bool userEdited = userCommand.ExecuteNonQuery() == 1;

                if(!userEdited)
                {
                    transaction.Rollback();
                    return false;
                }

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public bool UsernameExists(string username, int excludedId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) from Users Where Username = @Username And Id <> @Id", connection);
            
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Id", excludedId);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }
        public bool StudentNumberExists(string studentNumber, int excludedId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) from Students Where StudentNumber = @StudentNumber And Id <> @Id", connection);
            
            command.Parameters.AddWithValue("@StudentNumber", studentNumber);
            command.Parameters.AddWithValue("@Id", excludedId);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }
        public bool EmailExists(string email, int excludedId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) from Students Where Email = @Email And Id <> @Id", connection);
            
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Id", excludedId);

            return Convert.ToInt32(command.ExecuteScalar()) != 0;
        }

        public Student GetByUserId(int userId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("Select Students.Id, Students.UserId, Students.StudentNumber, Students.Email, Students.Phone, " +
                "Users.Username, Users.FullName, Users.IsActive From Students Inner Join Users on Students.UserId = Users.Id " +
                "Where Students.UserId = @UserId", connection);

            command.Parameters.AddWithValue("@UserId", userId);

            using SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            Student student = new Student
            {
                Id = (int)reader["Id"],
                UserId = (int)reader["UserId"],
                StudentNumber = (string)reader["StudentNumber"],
                Email = (string)reader["Email"],
                Phone = (string)reader["Phone"],
                Username = (string)reader["Username"],
                FullName = (string)reader["FullName"],
                IsActive = (bool)reader["IsActive"]
            };

            return student;
        }

        public bool UpdateStudentProfile(Student student, string? passwordHash)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                string userCommandSql = "Update Users Set Username = @Username, FullName = @FullName";

                if(!string.IsNullOrWhiteSpace(passwordHash))
                {
                    userCommandSql += ", PasswordHash = @PasswordHash";
                }

                userCommandSql += " Where Id = @Id";

                using SqlCommand userCommand = new(userCommandSql, connection, transaction);

                userCommand.Parameters.AddWithValue("@Username", student.Username);
                userCommand.Parameters.AddWithValue("@FullName", student.FullName);
                userCommand.Parameters.AddWithValue("@Id", student.UserId);

                if (!string.IsNullOrWhiteSpace(passwordHash))
                {
                    userCommand.Parameters.AddWithValue("@PasswordHash", passwordHash);
                }

                bool userEdited = userCommand.ExecuteNonQuery() == 1;

                if(!userEdited)
                {
                    transaction.Rollback();
                    return false;
                }

                using SqlCommand studentCommand = new("Update Students Set Phone = @Phone Where Id = @Id", connection, transaction);

                studentCommand.Parameters.AddWithValue("@Phone", student.Phone);
                studentCommand.Parameters.AddWithValue("@Id", student.Id);

                bool studentEdited = studentCommand.ExecuteNonQuery() == 1;

                if(!studentEdited)
                {
                    transaction.Rollback();
                    return false;
                }

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }
    }
}
