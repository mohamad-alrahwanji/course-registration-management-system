using CourseRegistration.DataAccess;
using CourseRegistration.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CourseRegistration.BusinessLogic
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly PasswordHasher<User> _passwordHasher = new();

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public bool Add(User user, string password)
        {
            if(string.IsNullOrWhiteSpace(user.Username)) throw new ArgumentException("Username cannot be empty.");
            if (user.Username.Length > 50) throw new ArgumentException("Username cannot exceed 50 characters.");
            if (string.IsNullOrWhiteSpace(user.FullName)) throw new ArgumentException("Full Name cannot be empty."); ;
            if (user.FullName.Length > 100) throw new ArgumentException("Full name cannot exceed 100 characters.");
            if (UsernameExists(user.Username)) throw new ArgumentException("Username already exists.");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Password is required.");
            if (password.Length < 8) throw new ArgumentException("Password must be at least 8 characters.");

            user.PasswordHash = _passwordHasher.HashPassword(user, password);

            return _userRepository.Add(user);
        }

        public bool UsernameExists(string username)
        {
            return _userRepository.UsernameExists(username);
        }

        public bool Edit(User user, string newPassword)
        {

            if (string.IsNullOrWhiteSpace(user.Username)) throw new ArgumentException("Username cannot be empty.");
            if (user.Username.Length > 50) throw new ArgumentException("Username cannot exceed 50 characters.");
            if (user.Role != "Student" && user.Role != "Administrator") throw new ArgumentException("Invalid role selected.");
            if (string.IsNullOrWhiteSpace(user.FullName)) throw new ArgumentException("Full Name cannot be empty."); ;
            if (user.FullName.Length > 100) throw new ArgumentException("Full name cannot exceed 100 characters.");
            if (_userRepository.UsernameExists(user.Username, user.Id)) throw new ArgumentException("Username already exists.");

            bool changePassword = !string.IsNullOrWhiteSpace(newPassword);

            if (changePassword)
            {
                if (newPassword.Length < 8) throw new ArgumentException("New password must be at least 8 characters.");

                user.PasswordHash = _passwordHasher.HashPassword(user, newPassword);
            }

            return _userRepository.Edit(user, changePassword);

        }

        public bool Delete(User user)
        {
            return _userRepository.Delete(user.Id);
        }

        public List<User> Search(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) return GetAll();
            return _userRepository.Search(searchText.Trim());
        }

        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Username and Password are required.");

            User? user = _userRepository.GetByUsername(username);

            if (user == null) throw new ArgumentException("Invalid username or password.");

            if (user.IsActive == false) throw new ArgumentException("This account is inactive.");

            PasswordVerificationResult result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);

            if (result == PasswordVerificationResult.Failed) throw new ArgumentException("Invalid username or password.");

            return user;
        }

    }
}
