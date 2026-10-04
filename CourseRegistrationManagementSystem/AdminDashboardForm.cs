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
    public partial class AdminDashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly UserService _userService;
        private readonly CourseService _courseService;
        private readonly StudentService _studentService;
        private readonly ClassService _classService;
        private readonly RegistrationService _registrationService;
        public AdminDashboardForm(User user, UserService userService, CourseService courseService, StudentService studentService, ClassService classService, RegistrationService registrationService)
        {
            InitializeComponent();
            _currentUser = user;
            _userService = userService;
            _courseService = courseService;
            _studentService = studentService;
            _classService = classService;
            _registrationService = registrationService;

            welcomeLabel.Text = $"Welcome, {user.FullName}";
        }

        private void ManageUsersButton_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(_userService, _studentService);
            userManagementForm.ShowDialog(this);
        }

        private void ManageCoursesButton_Click(object sender, EventArgs e)
        {
            CourseManagementForm courseManagementForm = new CourseManagementForm(_courseService);
            courseManagementForm.ShowDialog(this);
        }

        private void manageClassesButton_Click(object sender, EventArgs e)
        {
            ClassManagementForm classManagementForm = new ClassManagementForm(_classService, _courseService);
            classManagementForm.ShowDialog(this);
        }

        private void manageStudentsButton_Click(object sender, EventArgs e)
        {
            StudentManagementForm studentManagementForm = new StudentManagementForm(_studentService);
            studentManagementForm.ShowDialog(this);
        }

        private void registrationReportButton_Click(object sender, EventArgs e)
        {
            RegistrationReportForm registrationReportForm = new RegistrationReportForm(_courseService, _classService, _registrationService);
            registrationReportForm.ShowDialog(this);
        }
    }
}
