using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class CourseManagementForm : Form
    {
        public CourseManagementForm()
        {
            InitializeComponent();

            coursesGrid.DataSource = CourseService.GetAll();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            Course course = new Course
            {
                CourseCode = courseCodeTextBox.Text,
                CourseName = courseNameTextBox.Text,
                CreditHours = (int)creditHoursNumeric.Value,
                Description = string.IsNullOrWhiteSpace(descriptionTextBox.Text) ? null : descriptionTextBox.Text,
                IsActive = isActiveCheckBox.Checked
            };

            try
            {
                bool added = CourseService.Add(course);

                if (added)
                {
                    coursesGrid.DataSource = CourseService.GetAll();
                    MessageBox.Show("Course added successfully.");
                }

                else MessageBox.Show("The course could not be added.");
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {
            Course? selectedCourse = coursesGrid.CurrentRow?.DataBoundItem as Course;

            if (selectedCourse == null)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            DialogResult answer = MessageBox.Show($"Are you sure you want to delete {selectedCourse.CourseName}?", "Confirm deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool isDeleted = CourseService.Delete(selectedCourse);

                if (isDeleted)
                {
                    coursesGrid.DataSource = CourseService.GetAll();
                    MessageBox.Show("Course has been deleted successfully.");
                }

                else MessageBox.Show("Course could not be deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occured: {ex.Message}");
            }
        }

        private void editCourseButton_Click(object sender, EventArgs e)
        {
            Course? selectedCourse = coursesGrid.CurrentRow?.DataBoundItem as Course;
            if (selectedCourse == null)
            {
                MessageBox.Show("Please select a course to edit.");
                return;
            }

            EditCourseForm editCourseForm = new EditCourseForm(selectedCourse);
            DialogResult result = editCourseForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                coursesGrid.DataSource = CourseService.Search(courseSearchTextBox.Text);
            }
        }

        private void courseSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            coursesGrid.DataSource = CourseService.Search(courseSearchTextBox.Text);
        }
    }
}
