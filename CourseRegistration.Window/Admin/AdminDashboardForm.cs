using CourseRegistration.BL.Managers;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class AdminDashboardForm : Form
    {
        private readonly User _currentUser;
        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            welcomeLabel.Text = $"Welcome, {user.FullName}";
        }

        private void ManageUsersButton_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.ShowDialog(this);
        }

        private void ManageCoursesButton_Click(object sender, EventArgs e)
        {
            CourseManagementForm courseManagementForm = new CourseManagementForm();
            courseManagementForm.ShowDialog(this);
        }

        private void manageClassesButton_Click(object sender, EventArgs e)
        {
            ClassManagementForm classManagementForm = new ClassManagementForm();
            classManagementForm.ShowDialog(this);
        }

        private void manageStudentsButton_Click(object sender, EventArgs e)
        {
            StudentManagementForm studentManagementForm = new StudentManagementForm();
            studentManagementForm.ShowDialog(this);
        }

        private void registrationReportButton_Click(object sender, EventArgs e)
        {
            RegistrationReportForm registrationReportForm = new RegistrationReportForm();
            registrationReportForm.ShowDialog(this);
        }
    }
}
