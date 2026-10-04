using CourseRegistration.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseRegistration.Models;

namespace CourseRegistrationManagementSystem
{
    public partial class EditUserForm : Form
    {
        private readonly UserService _userService;
        private readonly User? _user;

        public EditUserForm(UserService userService, User user)
        {
            _userService = userService;
            _user = user;

            usernameTextBox.Text = _user.Username;
            fullNameTextBox.Text = _user.FullName;
            roleCombo.Text = _user.Role;
            isActiveCheckBox.Checked = _user.IsActive;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (_userService == null || _user == null) return;

            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            User user = new User
            {
                Id = _user.Id,
                Username = usernameTextBox.Text,
                FullName = fullNameTextBox.Text,
                Role = roleCombo.Text,
                IsActive = isActiveCheckBox.Checked
            };

            try
            {
                bool changesSaved = _userService.Edit(user, newPasswordTextBox.Text);

                if (changesSaved)
                {
                    MessageBox.Show("Changes saved successfully.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Could not save changes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ocurred: {ex.Message}");
            }
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
