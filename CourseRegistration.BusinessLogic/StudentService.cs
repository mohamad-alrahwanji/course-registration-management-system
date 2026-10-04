using CourseRegistration.DataAccess;
using CourseRegistration.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CourseRegistration.BusinessLogic
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;
        private readonly PasswordHasher<User> _passwordHasher = new();
        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public bool Add(User user, Student student, string password, string confirmedPassword)
        {
            if (string.IsNullOrWhiteSpace(user.Username)) throw new ArgumentException("Username cannot be empty.");
            if (user.Username.Length > 50) throw new ArgumentException("Username cannot exceed 50 characters.");
            if (string.IsNullOrWhiteSpace(user.FullName)) throw new ArgumentException("Full Name cannot be empty.");
            if (user.FullName.Length > 100) throw new ArgumentException("Full name cannot exceed 100 characters.");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Password is required.");
            if (password.Length < 8) throw new ArgumentException("Password must be at least 8 characters.");
            if (!Regex.IsMatch(student.StudentNumber, @"^\d{10}$")) throw new ArgumentException("Student number must exactly be 10 digits.");
            if (string.IsNullOrWhiteSpace(student.Email)) throw new ArgumentException("Email cannot be empty.");
            if (string.IsNullOrWhiteSpace(student.Phone)) throw new ArgumentException("Phone cannot be empty.");
            if (password != confirmedPassword) throw new ArgumentException("Password does not match confirmation password.");
            if (_studentRepository.EmailExists(student.Email)) throw new ArgumentException("Email is already in use.");
            if (_studentRepository.UsernameExists(user.Username)) throw new ArgumentException("Username is taken.");
            if (_studentRepository.StudentNumberExists(student.StudentNumber)) throw new ArgumentException("StudentNumber is taken.");

            user.Role = "Student";
            user.PasswordHash = _passwordHasher.HashPassword(user, password);

            return _studentRepository.Add(user, student);
        }

        public List<Student> Search(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return GetAll();

            return _studentRepository.Search(searchText.Trim());
        }

        public bool Delete(Student student)
        {
            return _studentRepository.Delete(student.Id, student.UserId);
        }

        public bool Edit(Student student, User user, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(user.Username)) throw new ArgumentException("Username cannot be empty.");
            if (user.Username.Length > 50) throw new ArgumentException("Username cannot exceed 50 characters.");
            if (string.IsNullOrWhiteSpace(user.FullName)) throw new ArgumentException("Full Name cannot be empty.");
            if (user.FullName.Length > 100) throw new ArgumentException("Full name cannot exceed 100 characters.");
            if (!Regex.IsMatch(student.StudentNumber, @"^\d{10}$")) throw new ArgumentException("Student number must exactly be 10 digits.");
            if (string.IsNullOrWhiteSpace(student.Email)) throw new ArgumentException("Email cannot be empty.");
            if (string.IsNullOrWhiteSpace(student.Phone)) throw new ArgumentException("Phone cannot be empty.");
            if (_studentRepository.EmailExists(student.Email, student.Id)) throw new ArgumentException("Email is already in use.");
            if (_studentRepository.UsernameExists(user.Username, user.Id)) throw new ArgumentException("Username is taken.");
            if (_studentRepository.StudentNumberExists(student.StudentNumber, student.Id)) throw new ArgumentException("StudentNumber is taken.");

            bool passwordChanged = !string.IsNullOrWhiteSpace(newPassword);

            if(passwordChanged)
            {
                if (newPassword.Length < 8) throw new ArgumentException("Password must be at least 8 characters.");

                user.PasswordHash = _passwordHasher.HashPassword(user, newPassword);    
            }

            user.Role = "Student";

            return _studentRepository.Edit(user, student, passwordChanged);
        }

        public Student GetByUserId(int userId)
        {
            return _studentRepository.GetByUserId(userId);
        }

        public bool UpdateStudentProfile(Student student, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(student.Username)) throw new ArgumentException("Username cannot be empty.");
            if (student.Username.Length > 50) throw new ArgumentException("Username cannot exceed 50 characters.");
            if (string.IsNullOrWhiteSpace(student.FullName)) throw new ArgumentException("Full Name cannot be empty.");
            if (student.FullName.Length > 100) throw new ArgumentException("Full name cannot exceed 100 characters.");
            if (string.IsNullOrWhiteSpace(student.Phone)) throw new ArgumentException("Phone cannot be empty.");
            if (_studentRepository.UsernameExists(student.Username, student.UserId)) throw new ArgumentException("Username is taken.");

            string? passwordHash = null;

            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                if (newPassword.Length < 8) throw new ArgumentException("Password must be at least 8 characters.");

                User user = new User();
                passwordHash = _passwordHasher.HashPassword(user, newPassword);
            }

            return _studentRepository.UpdateStudentProfile(student, passwordHash);
        }
    }
}
