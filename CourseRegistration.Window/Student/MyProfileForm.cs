using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class MyProfileForm : Form
    {
        private readonly Student _student;
        public MyProfileForm(Student student)
        {
            InitializeComponent();

            _student = student;

            usernameTextBox.Text = _student.Username;
            fullNameTextBox.Text = _student.FullName;
            studentNumberTextBox.Text = _student.StudentNumber;
            emailTextBox.Text = _student.Email;
            phoneTextBox.Text = _student.Phone;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(newPasswordTextBox.Text) && newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                Student student = new Student
                {
                    Id = _student.Id,
                    UserId = _student.UserId,
                    Username = usernameTextBox.Text,
                    FullName = fullNameTextBox.Text,
                    Email = emailTextBox.Text,
                    Phone = phoneTextBox.Text,
                };

                bool updated = StudentService.UpdateStudentProfile(student, newPasswordTextBox.Text);

                if(!updated)
                {
                    MessageBox.Show("Changes could not be saved.");
                    return;
                }

                MessageBox.Show("Profile updated successfully.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
