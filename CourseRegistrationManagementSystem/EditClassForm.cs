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
    public partial class EditClassForm : Form
    {
        private readonly ClassService? _classService;
        private readonly CourseService? _courseService;
        private readonly Class? _class;
        public EditClassForm(ClassService classService, CourseService courseService, Class courseClass)
        {
            InitializeComponent();

            _classService = classService;
            _courseService = courseService;
            _class = courseClass;

            courseNameCombo.DataSource = _courseService.GetAll();
            courseNameCombo.DisplayMember = "CourseName";

            classNameTextBox.Text = _class.ClassName;
            courseNameCombo.Text = _class.CourseName;
            instructorTextBox.Text = _class.Instructor;
            capacityNumeric.Value = _class.Capacity;
            startDateTimePicker.Value = _class.StartDate;
            endDateTimePicker.Value = _class.EndDate;
            satCheckBox.Checked = _class.Schedule.Contains("Sat");
            sunCheckBox.Checked = _class.Schedule.Contains("Sun");
            monCheckBox.Checked = _class.Schedule.Contains("Mon");
            tueCheckBox.Checked = _class.Schedule.Contains("Tue");
            wedCheckBox.Checked = _class.Schedule.Contains("Wed");
            thuCheckBox.Checked = _class.Schedule.Contains("Thu");
            friCheckBox.Checked = _class.Schedule.Contains("Fri");
            isActiveCheckBox.Checked = _class.IsActive;

            string[] parts = _class.Schedule.Split(' ');
            startTimePicker.Value = DateTime.Parse(parts[1] + " " + parts[2]);
            endTimePicker.Value = DateTime.Parse(parts[4] + " " + parts[5]);

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (_classService == null || _courseService == null || _class == null) return;

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
                Id = _class.Id,
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
                bool changesSaved = _classService.Edit(courseClass);

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
    }
}
