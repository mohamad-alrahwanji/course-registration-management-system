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
    public partial class StudentDashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly StudentService _studentService;
        private readonly ClassService _classService;
        private readonly RegistrationService _registrationService;
        private readonly Student _currentStudent;
        public StudentDashboardForm(User user, StudentService studentService, ClassService classService, RegistrationService registrationService)
        {
            InitializeComponent();
            _currentUser = user;
            _studentService = studentService;
            _classService = classService;
            _registrationService = registrationService;
            _currentStudent = _studentService.GetByUserId(_currentUser.Id);

            welcomeLabel.Text = $"Welcome, {user.FullName}";
        }

        private void BrowsesClassesButton_Click(object sender, EventArgs e)
        {
            BrowseClassesForm availableClassesForm = new BrowseClassesForm(_classService, _registrationService, _currentStudent);
            availableClassesForm.ShowDialog(this);
        }

        private void registrationHistoryButton_Click(object sender, EventArgs e)
        {
            RegistrationHistoryForm registrationHistoryForm = new RegistrationHistoryForm(_registrationService, _currentStudent);
            registrationHistoryForm.ShowDialog(this);
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            MyProfileForm profileForm = new MyProfileForm(_currentStudent, _studentService);
            profileForm.ShowDialog(this);
        }
    }
}
