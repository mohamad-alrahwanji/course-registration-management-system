using CourseRegistration.Entities;
using Framework.Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace CourseRegistration.DAL.DataProviders;

internal static class ClassDataProvider
{
    internal static List<Class> GetAll()
    {
        List<Class> classes = new List<Class>();

        using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
        connection.Open();

        using SqlCommand command = new("Select Classes.Id, Classes.ClassName, Classes.Instructor, Classes.Capacity, Classes.StartDate, " +
            "Classes.EndDate, Classes.Schedule, Classes.IsActive, Classes.CourseId, Courses.CourseName, Courses.CourseCode, " +
            "(Select Count(*) From Registrations Where Registrations.ClassId = Classes.Id And Registrations.Status = 'Active') As RegisteredCount " +
            "From Classes Inner Join Courses On Classes.CourseId = Courses.Id", connection);

        using SqlDataReader reader = command.ExecuteReader();

        while(reader.Read())
        {
            Class courseClass = new Class
            {
                Id = (int)reader["Id"],
                CourseCode = (string)reader["CourseCode"],
                CourseId = (int)reader["CourseId"],
                ClassName = (string)reader["ClassName"],
                CourseName = (string)reader["CourseName"],
                Instructor = (string)reader["Instructor"],
                Capacity = (int)reader["Capacity"],
                RegisteredCount = (int)reader["RegisteredCount"],
                StartDate = (DateTime)reader["StartDate"],
                EndDate = (DateTime)reader["EndDate"],
                Schedule = (string)reader["Schedule"],
                IsActive = (bool)reader["IsActive"]
            };
            classes.Add(courseClass);
        }
        return classes;
    }

    internal static bool Add(Class courseClass)
    {
        using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
        connection.Open();

        using SqlCommand command = new("Insert Into Classes (CourseId, ClassName, Instructor, Capacity, StartDate, EndDate, Schedule, IsActive) " +
            "Values (@CourseId, @ClassName, @Instructor, @Capacity, @StartDate, @EndDate, @Schedule, @IsActive)", connection);

        command.Parameters.AddWithValue("@CourseId", courseClass.CourseId);
        command.Parameters.AddWithValue("@ClassName", courseClass.ClassName);
        command.Parameters.AddWithValue("@Instructor", courseClass.Instructor);
        command.Parameters.AddWithValue("@Capacity", courseClass.Capacity);
        command.Parameters.AddWithValue("@StartDate", courseClass.StartDate);
        command.Parameters.AddWithValue("@EndDate", courseClass.EndDate);
        command.Parameters.AddWithValue("@Schedule", courseClass.Schedule);
        command.Parameters.AddWithValue("@IsActive", courseClass.IsActive);

        return command.ExecuteNonQuery() == 1;
    }

    internal static bool Delete(int classId)
    {
        using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
        connection.Open();

        using SqlCommand command = new("Delete from Classes where Id = @Id", connection);

        command.Parameters.AddWithValue("@Id", classId);

        return command.ExecuteNonQuery() == 1;
    }

    internal static bool Edit(Class courseClass)
    {
        using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
        connection.Open();

        using SqlCommand command = new("Update Classes Set CourseId = @CourseId, ClassName = @ClassName, Instructor = @Instructor, " +
            "Capacity = @Capacity, StartDate = @StartDate, EndDate = @EndDate, Schedule = @Schedule, IsActive = @IsActive Where Id = @Id", 
            connection);

        command.Parameters.AddWithValue("@CourseId", courseClass.CourseId);
        command.Parameters.AddWithValue("@ClassName", courseClass.ClassName);
        command.Parameters.AddWithValue("@Instructor", courseClass.Instructor); 
        command.Parameters.AddWithValue("@Capacity", courseClass.Capacity);
        command.Parameters.AddWithValue("@StartDate", courseClass.StartDate);
        command.Parameters.AddWithValue("@EndDate", courseClass.EndDate);
        command.Parameters.AddWithValue("@Schedule", courseClass.Schedule);
        command.Parameters.AddWithValue("@IsActive", courseClass.IsActive);
        command.Parameters.AddWithValue("@Id", courseClass.Id);

        return command.ExecuteNonQuery() == 1;
    }

    internal static List<Class> Search(string searchText)
    {
        List<Class> classes = new List<Class>();
        using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
        connection.Open();

        using SqlCommand command = new("Select Classes.Id, Classes.ClassName, Classes.Instructor, Classes.Capacity, Classes.StartDate, " +
            "Classes.EndDate, Classes.Schedule, Classes.IsActive, Classes.CourseId, Courses.CourseName, Courses.CourseCode, " +
            "(Select Count(*) From Registrations Where Registrations.ClassId = Classes.Id And Registrations.Status = 'Active') As RegisteredCount " +
            "From Classes Inner Join Courses On Classes.CourseId = Courses.Id " +
            "Where Classes.ClassName Like @Search Or Courses.CourseName Like @Search", connection);

        command.Parameters.AddWithValue("@Search", $"%{searchText}%");
        
        using SqlDataReader reader = command.ExecuteReader();

        while(reader.Read())
        {
            Class courseClass = new Class
            {
                Id = (int)reader["Id"],
                CourseCode = (string)reader["CourseCode"],
                CourseId = (int)reader["CourseId"],
                ClassName = (string)reader["ClassName"],
                CourseName = (string)reader["CourseName"],
                Instructor = (string)reader["Instructor"],
                Capacity = (int)reader["Capacity"],
                RegisteredCount = (int)reader["RegisteredCount"],
                StartDate = (DateTime)reader["StartDate"],
                EndDate = (DateTime)reader["EndDate"],
                Schedule = (string)reader["Schedule"],
                IsActive = (bool)reader["IsActive"]
            };
            classes.Add(courseClass);
        }
        return classes;
    }

    internal static List<Class> GetActive()
    {
        List<Class> classes = new List<Class>();

        using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
        connection.Open();

        using SqlCommand command = new("Select Classes.Id, Classes.CourseId, Classes.ClassName, Classes.Instructor, Classes.Capacity, " +
            "Classes.StartDate, Classes.EndDate, Classes.Schedule, Classes.IsActive, Courses.CourseName, Courses.CourseCode, " +
            "(Select Count(*) From Registrations Where Registrations.ClassId = Classes.Id And Registrations.Status = 'Active') As RegisteredCount " +
            "From Classes Inner Join Courses On Classes.CourseId = Courses.Id Where Classes.IsActive = 1", connection);

        using SqlDataReader reader = command.ExecuteReader();

        while(reader.Read())
        {
            Class courseClass = new Class
            {
                Id = (int)reader["Id"],
                CourseId = (int)reader["CourseId"],
                CourseCode = (string)reader["CourseCode"],
                CourseName = (string)reader["CourseName"],
                ClassName = (string)reader["ClassName"],
                Instructor = (string)reader["Instructor"],
                Capacity = (int)reader["Capacity"],
                RegisteredCount = (int)reader["RegisteredCount"],
                StartDate = (DateTime)reader["StartDate"],
                EndDate = (DateTime)reader["EndDate"],
                Schedule = (string)reader["Schedule"],
                IsActive = (bool)reader["IsActive"]
            };

            classes.Add(courseClass);
        }

        return classes;
    }

    internal static bool IsAvailable(int classId)
    {
        using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
        connection.Open();

        using SqlCommand command = new("Select Count(*) From Classes Where Id = @Id And IsActive = 1 And (Select Count(*) From " +
            "Registrations Where Registrations.ClassId = Classes.Id And Registrations.Status = 'Active') < Capacity", connection);
        
        command.Parameters.AddWithValue("@Id", classId);

        return Convert.ToInt32(command.ExecuteScalar()) != 0;
    }

    internal static List<Class> SearchActive(string searchText)
    {
        List<Class> classes = new List<Class>();

        using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
        connection.Open();

        using SqlCommand command = new("Select Classes.Id, Classes.CourseId, Classes.ClassName, Classes.Instructor, Classes.Capacity, " +
            "Classes.StartDate, Classes.EndDate, Classes.Schedule, Classes.IsActive, Courses.CourseName, Courses.CourseCode, " +
            "(Select Count(*) From Registrations Where Registrations.ClassId = Classes.Id And Registrations.Status = 'Active') As RegisteredCount " +
            "From Classes Inner Join Courses On Classes.CourseId = Courses.Id Where Classes.IsActive = 1 And " +
            "(Courses.CourseName Like @Search Or Courses.CourseCode Like @Search)", connection);

        command.Parameters.AddWithValue("@Search", $"%{searchText}%");

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Class courseClass = new Class
            {
                Id = (int)reader["Id"],
                CourseId = (int)reader["CourseId"],
                CourseCode = (string)reader["CourseCode"],
                CourseName = (string)reader["CourseName"],
                ClassName = (string)reader["ClassName"],
                Instructor = (string)reader["Instructor"],
                Capacity = (int)reader["Capacity"],
                RegisteredCount = (int)reader["RegisteredCount"],
                StartDate = (DateTime)reader["StartDate"],
                EndDate = (DateTime)reader["EndDate"],
                Schedule = (string)reader["Schedule"],
                IsActive = (bool)reader["IsActive"]
            };

            classes.Add(courseClass);
        }

        return classes;
    }

    internal static List<Class> GetByCourseId(int courseId)
    {
        List<Class> classes = new List<Class>();

        using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
        connection.Open();

        using SqlCommand command = new("Select Classes.Id, Classes.ClassName, Classes.Instructor, Classes.Capacity, Classes.StartDate, " +
            "Classes.EndDate, Classes.Schedule, Classes.IsActive, Classes.CourseId, Courses.CourseName, Courses.CourseCode, " +
            "(Select Count(*) From Registrations Where Registrations.ClassId = Classes.Id And Registrations.Status = 'Active') As RegisteredCount " +
            "From Classes Inner Join Courses On Classes.CourseId = Courses.Id Where Classes.CourseId = @CourseId", connection);

        command.Parameters.AddWithValue("@CourseId", courseId);

        using SqlDataReader reader = command.ExecuteReader();

        while(reader.Read())
        {
            Class courseClass = new Class
            {
                Id = (int)reader["Id"],
                CourseId = (int)reader["CourseId"],
                CourseCode = (string)reader["CourseCode"],
                CourseName = (string)reader["CourseName"],
                ClassName = (string)reader["ClassName"],
                Instructor = (string)reader["Instructor"],
                Capacity = (int)reader["Capacity"],
                RegisteredCount = (int)reader["RegisteredCount"],
                StartDate = (DateTime)reader["StartDate"],
                EndDate = (DateTime)reader["EndDate"],
                Schedule = (string)reader["Schedule"],
                IsActive = (bool)reader["IsActive"]
            };
            classes.Add(courseClass);
        }
        return classes;
    }

    internal static string GetSchedule(int classId)
    {
        using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
        connection.Open();

        using SqlCommand command = new(
            "Select Schedule From Classes Where Id = @ClassId",
            connection);

        command.Parameters.AddWithValue("@ClassId", classId);

        return (string)command.ExecuteScalar();
    }
}
