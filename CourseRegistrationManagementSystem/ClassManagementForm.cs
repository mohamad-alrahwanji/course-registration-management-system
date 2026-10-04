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
    public partial class ClassManagementForm : Form
    {
        private readonly ClassService _classService;
        private readonly CourseService _courseService;
        public ClassManagementForm(ClassService classService, CourseService courseService)
        {
            InitializeComponent();

            _classService = classService;
            _courseService = courseService;

            startTimePicker.Value = DateTime.Today.AddHours(9);
            endTimePicker.Value = DateTime.Today.AddHours(10);

            classGridView.DataSource = _classService.GetAll();
            classGridView.Columns["CourseId"]?.Visible = false;

            courseNameCombo.DataSource = _courseService.GetAll();
            courseNameCombo.DisplayMember = "CourseName";
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            Course? selectedCourse = courseNameCombo.SelectedItem as Course;

            if (selectedCourse == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            List<string> days = new List<String>();

            if (sunCheckBox.Checked) days.Add("Sun");
            if (monCheckBox.Checked) days.Add("Mon");
            if (tueCheckBox.Checked) days.Add("Tue");
            if (wedCheckBox.Checked) days.Add("Wed");
            if (thuCheckBox.Checked) days.Add("Thu");
            if (friCheckBox.Checked) days.Add("Fri");
            if (satCheckBox.Checked) days.Add("Sat");

            if (days.Count == 0)
            {
                MessageBox.Show("Please select at least one day.");
                return;
            }

            if (startTimePicker.Value.TimeOfDay >= endTimePicker.Value.TimeOfDay)
            {
                MessageBox.Show("Start time must be before end time.");
                return;
            }

            string schedule = $"{string.Join("/", days)} {startTimePicker.Value:h:mm tt} - {endTimePicker.Value:h:mm tt}";

            Class courseClass = new Class
            {
                CourseId = selectedCourse.Id,
                ClassName = classNameTextBox.Text,
                Instructor = instructorTextBox.Text,
                Capacity = (int)capacityNumeric.Value,
                StartDate = startDateTimePicker.Value.Date,
                EndDate = endDateTimePicker.Value.Date,
                Schedule = schedule,
                IsActive = isActiveCheckBox.Checked
            };

            try
            {
                bool added = _classService.Add(courseClass);

                if (added)
                {
                    MessageBox.Show("Class added successfully.");
                    classGridView.DataSource = _classService.Search(classSearchTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Class could not be added.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown error has occured: {ex.Message}");
            }
            
        }

        private void DeleteClassButton_Click(object sender, EventArgs e)
        {
            Class? selectedClass = classGridView.CurrentRow?.DataBoundItem as Class;

            if (selectedClass == null)
            {
                MessageBox.Show("Please select a class to delete.");
                return;
            }

            DialogResult answer = MessageBox.Show($"Are you sure you want to delete {selectedClass.CourseName} from {selectedClass.ClassName}?",
                "Confirm deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool isDeleted = _classService.Delete(selectedClass);

                if (isDeleted)
                {
                    classGridView.DataSource = _classService.GetAll();
                    MessageBox.Show("Class has been deleted successfully.");
                }

                else MessageBox.Show("Class could not be deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occured: {ex.Message}");
            }
        }

        private void editClassButton_Click(object sender, EventArgs e)
        {
            Class? selectedClass = classGridView.CurrentRow?.DataBoundItem as Class;

            if (selectedClass == null)
            {
                MessageBox.Show("Please select a class to edit.");
                return;
            }

            EditClassForm editClassForm = new EditClassForm(_classService, _courseService, selectedClass);
            DialogResult result = editClassForm.ShowDialog(this);

            if(result == DialogResult.OK)
            {
                classGridView.DataSource = _classService.Search(classSearchTextBox.Text);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            classGridView.DataSource = _classService.Search(classSearchTextBox.Text);
        }
    }
}
