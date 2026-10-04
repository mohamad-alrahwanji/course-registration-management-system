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
    public partial class UserManagementForm : Form
    {
        private readonly StudentService _studentService;
        private readonly UserService _userService;
        public UserManagementForm(UserService userService, StudentService studentService)
        {
            InitializeComponent();

            _userService = userService;
            _studentService = studentService;

            usersGrid.DataSource = _userService.GetAll();

            DataGridViewColumn? passwordColumn = usersGrid.Columns["PasswordHash"];

            if (passwordColumn != null)
            {
                passwordColumn.Visible = false;
            }
        }

        public void tabPage1_Click(object sender, EventArgs e) { }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {

            if (adminPasswordTextBox.Text != adminConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            ;

            User user = new User
            {
                Username = adminUsernameTextBox.Text,
                FullName = adminFullNameTextBox.Text,
                Role = "Administrator",
                IsActive = adminIsActiveCheckBox.Checked
            };

            try
            {
                bool added = _userService.Add(user, adminPasswordTextBox.Text);

                if (added) MessageBox.Show("Admin added successfully.");
                else MessageBox.Show("Admin could not be added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_userService == null) return;

            usersGrid.DataSource = _userService.Search(userSearchTextBox.Text);
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            User? selectedUser = usersGrid.CurrentRow?.DataBoundItem as User;

            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            if(selectedUser.Role == "Student")
            {
                MessageBox.Show("Student accounts must be edited from Student Management.");
                return;
            }

            EditUserForm editForm = new EditUserForm(_userService, selectedUser);
            DialogResult result = editForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                usersGrid.DataSource = _userService.Search(userSearchTextBox.Text);
            }

        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            User? selectedUser = usersGrid.CurrentRow?.DataBoundItem as User;

            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            if (selectedUser.Role == "Student")
            {
                MessageBox.Show("Student accounts must be deleted from Student Management.");
                return;
            }

            DialogResult answer = MessageBox.Show($"Are you sure you want to delete {selectedUser.Username}?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes) return;

            try
            {
                bool isDeleted = _userService.Delete(selectedUser);

                if (isDeleted)
                {
                    usersGrid.DataSource = _userService.GetAll();
                    MessageBox.Show("User has been deleted successfully.");
                }

                else MessageBox.Show("User could not be deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occured: {ex.Message}");
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = stdUsernameTextBox.Text,
                FullName = stdFullNameTextBox.Text,
                IsActive = stdIsActiveCheckBox.Checked
            };

            Student student = new Student
            {
                StudentNumber = studentNumberTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
            };

            try
            {
                bool added = _studentService.Add(user, student, stdPasswordTextBox.Text, stdConfirmPasswordTextBox.Text);

                if (added)
                {
                    MessageBox.Show("Student added successfully.");
                    usersGrid.DataSource = _userService.GetAll();
                }
                else MessageBox.Show("Student could not be added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
