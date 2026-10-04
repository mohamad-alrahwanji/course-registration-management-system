using CourseRegistration.BusinessLogic;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseRegistrationManagementSystem
{
    public partial class RegistrationReportForm : Form
    {
        private readonly CourseService _courseService;
        private readonly ClassService _classService;
        private readonly RegistrationService _registrationService;
        public RegistrationReportForm(CourseService courseService, ClassService classService, RegistrationService registrationService)
        {
            InitializeComponent();

            _courseService = courseService;
            _classService = classService;
            _registrationService = registrationService;

            courseCombo.DataSource = _courseService.GetAll();
            courseCombo.DisplayMember = "CourseName";

            ReportsGridView.DataSource = _classService.GetAll();
            ReportsGridView.Columns["Id"]?.Visible = false;
            ReportsGridView.Columns["CourseId"]?.Visible = false;
            ReportsGridView.Columns["IsActive"]?.Visible = false;

        }

        private void CourseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course? course = courseCombo.SelectedItem as Course;

            if (course == null)
            {
                ReportsGridView.DataSource = _classService.GetAll();
                classCombo.DataSource = null;
                return;
            }

            List<Class> classes = _classService.GetByCourseId(course.Id);

            ReportsGridView.DataSource = classes;

            List<string> classNames = new List<string>();

            foreach (Class courseClass in classes)
            {
                if (!classNames.Contains(courseClass.ClassName))
                {
                    classNames.Add(courseClass.ClassName);
                }
            }

            classCombo.DataSource = classNames;
            classCombo.SelectedIndex = -1;
        }

        private void viewRegisteredStudentsButton_Click(object sender, EventArgs e)
        {
            Class? selectedClass = ReportsGridView.CurrentRow?.DataBoundItem as Class;

            if (selectedClass == null)
            {
                MessageBox.Show("Please select a class");
                return;
            }

            ClassRegistrationsForm classRegistrationsForm = new ClassRegistrationsForm(_registrationService, selectedClass);
            classRegistrationsForm.ShowDialog(this);
        }

        private void classCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course? selectedCourse = courseCombo.SelectedItem as Course;

            if (selectedCourse == null)
            {
                ReportsGridView.DataSource = _classService.GetAll();
                return;
            }

            List<Class> classes = _classService.GetByCourseId(selectedCourse.Id);

            if (classCombo.SelectedIndex == -1)
            {
                ReportsGridView.DataSource = classes;
                return;
            }

            List<Class> filteredClasses = new List<Class>();

            foreach (Class courseClass in classes)
            {
                if (courseClass.ClassName == classCombo.Text)
                {
                    filteredClasses.Add(courseClass);
                }
            }

            ReportsGridView.DataSource = filteredClasses;
        }
    }
}
