using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseRegistration.BusinessLogic;
using CourseRegistration.Models;

namespace CourseRegistrationManagementSystem
{
    public partial class MyProfileForm : Form
    {
        private readonly Student _student;
        private readonly StudentService _studentService;
        public MyProfileForm(Student student, StudentService studentService)
        {
            InitializeComponent();

            _student = student;
            _studentService = studentService;

            usernameTextBox.Text = _student.Username;
            fullNameTextBox.Text = _student.FullName;
            studentNumberTextBox.Text = _student.StudentNumber;
            emailTextBox.Text = _student.Email;
            phoneTextBox.Text = _student.Phone;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(newPasswordTextBox.Text) && newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                Student student = new Student
                {
                    Id = _student.Id,
                    UserId = _student.UserId,
                    Username = usernameTextBox.Text,
                    FullName = fullNameTextBox.Text,
                    Email = emailTextBox.Text,
                    Phone = phoneTextBox.Text,
                };

                bool updated = _studentService.UpdateStudentProfile(student, newPasswordTextBox.Text);

                if(!updated)
                {
                    MessageBox.Show("Changes could not be saved.");
                    return;
                }

                MessageBox.Show("Profile updated successfully.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
