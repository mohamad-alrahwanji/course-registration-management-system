using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseRegistration.BusinessLogic;
using CourseRegistration.DataAccess;
using CourseRegistration.Models;

namespace CourseRegistrationManagementSystem
{
    public partial class EditCourseForm : Form
    {
        private readonly CourseService? _courseService;
        private readonly Course? _course;
        public EditCourseForm()
        {
            InitializeComponent();
        }

        public EditCourseForm(CourseService courseService, Course course) : this()
        {
            _courseService = courseService;
            _course = course;

            courseCodeTextBox.Text = course.CourseCode;
            courseNameTextBox.Text = course.CourseName;
            creditHoursNumeric.Value = course.CreditHours;
            descriptionTextBox.Text = course.Description ?? string.Empty;
            isActiveCheckBox.Checked = course.IsActive;
        }

        private void EditCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (_courseService == null || _course == null) return;

            Course course = new Course
            {
                Id = _course.Id,
                CourseCode = courseCodeTextBox.Text,
                CourseName = courseNameTextBox.Text,
                CreditHours = (int)creditHoursNumeric.Value,
                Description = string.IsNullOrWhiteSpace(descriptionTextBox.Text) ? null : descriptionTextBox.Text,
                IsActive = isActiveCheckBox.Checked
            };

            try
            {
                bool changesSaved = _courseService.Edit(course);

                if (changesSaved)
                {
                    MessageBox.Show("Changes saved successfully.");
                    DialogResult = DialogResult.OK;
                    Close();
                }

                else MessageBox.Show("Could not save changes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}");
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
