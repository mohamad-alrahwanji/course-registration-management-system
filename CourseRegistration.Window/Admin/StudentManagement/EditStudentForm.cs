using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class EditStudentForm : Form
    {
        private readonly Student _student;
        public EditStudentForm(Student student)
        {
            InitializeComponent();

            _student = student;

            stdUsernameTextBox.Text = student.Username;
            stdFullNameTextBox.Text = student.FullName;
            studentNumberTextBox.Text = student.StudentNumber;
            emailTextBox.Text = student.Email;
            phoneTextBox.Text = student.Phone;
            stdIsActiveCheckBox.Checked = student.IsActive;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Id = _student.Id,
                UserId = _student.UserId,
                StudentNumber = studentNumberTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
            };

            User user = new User
            {
                Id = _student.UserId,
                Username = stdUsernameTextBox.Text,
                FullName = stdFullNameTextBox.Text,
                IsActive = stdIsActiveCheckBox.Checked,
            };

            if (stdNewPasswordTextBox.Text != stdConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                bool changesSaved = StudentService.Edit(student, user, stdNewPasswordTextBox.Text);

                if(changesSaved)
                {
                    MessageBox.Show("Changes saved successfully.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Changes could not be saved.");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error occured: {ex.Message}");
            }
        }
    }
}
