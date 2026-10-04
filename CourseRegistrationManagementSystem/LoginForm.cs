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
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        private readonly CourseService _courseService;
        private readonly StudentService _studentService;
        private readonly ClassService _classService;
        private readonly RegistrationService _registrationService;
        public LoginForm(UserService userService, CourseService courseService, StudentService studentService, ClassService classService,
            RegistrationService registrationService)
        {
            InitializeComponent();
            _userService = userService;
            _courseService = courseService;
            _studentService = studentService;
            _classService = classService;
            _registrationService = registrationService;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _userService.Login(usernameTextBox.Text, passwordTextBox.Text);

                Form dashboard;

                if (user.Role == "Administrator")
                {
                    dashboard = new AdminDashboardForm(user, _userService, _courseService, _studentService, _classService, _registrationService);
                }
                else
                {
                    dashboard = new StudentDashboardForm(user, _studentService, _classService, _registrationService);
                }

                Hide();

                dashboard.ShowDialog(this);

                passwordTextBox.Clear();
                Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch
            {
                MessageBox.Show("An unknown error has occured. Please try again later.");
            }

        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }
    }
}
