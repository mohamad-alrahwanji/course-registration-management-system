using CourseRegistration.BusinessLogic;
using CourseRegistration.Models;

namespace CourseRegistrationManagementSystem
{
    public partial class CourseManagementForm : Form
    {
        private readonly CourseService _courseService;
        public CourseManagementForm(CourseService courseService)
        {
            InitializeComponent();

            _courseService = courseService;
            coursesGrid.DataSource = _courseService.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void coursesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                bool added = _courseService.Add(course);

                if (added)
                {
                    coursesGrid.DataSource = _courseService.GetAll();
                    MessageBox.Show("Course added successfully.");
                }

                else MessageBox.Show("The course could not be added.");
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void searchCourseButton_Click(object sender, EventArgs e)
        {

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
                bool isDeleted = _courseService.Delete(selectedCourse);

                if (isDeleted)
                {
                    coursesGrid.DataSource = _courseService.GetAll();
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

            EditCourseForm editCourseForm = new EditCourseForm(_courseService, selectedCourse);
            DialogResult result = editCourseForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                coursesGrid.DataSource = _courseService.Search(courseSearchTextBox.Text);
            }
        }

        private void courseSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            coursesGrid.DataSource = _courseService.Search(courseSearchTextBox.Text);
        }
    }
}
