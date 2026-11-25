using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class StudentDashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly Student _currentStudent;
        public StudentDashboardForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _currentStudent = StudentService.GetByUserId(_currentUser.Id);

            welcomeLabel.Text = $"Welcome, {user.FullName}";
        }

        private void BrowsesClassesButton_Click(object sender, EventArgs e)
        {
            BrowseClassesForm availableClassesForm = new BrowseClassesForm(_currentStudent);
            availableClassesForm.ShowDialog(this);
        }

        private void registrationHistoryButton_Click(object sender, EventArgs e)
        {
            RegistrationHistoryForm registrationHistoryForm = new RegistrationHistoryForm(_currentStudent);
            registrationHistoryForm.ShowDialog(this);
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            Student student = StudentService.GetByUserId(_currentUser.Id);
            MyProfileForm profileForm = new MyProfileForm(student);
            profileForm.ShowDialog(this);
        }
    }
}
