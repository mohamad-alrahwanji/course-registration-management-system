using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class EditCourseForm : Form
    {
        private readonly Course? _course;
        public EditCourseForm()
        {
            InitializeComponent();
        }

        public EditCourseForm(Course course)
        {
            InitializeComponent();

            _course = course;

            courseCodeTextBox.Text = course.CourseCode;
            courseNameTextBox.Text = course.CourseName;
            creditHoursNumeric.Value = course.CreditHours;
            descriptionTextBox.Text = course.Description ?? string.Empty;
            isActiveCheckBox.Checked = course.IsActive;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (_course == null) return;

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
                bool changesSaved = CourseService.Edit(course);

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
