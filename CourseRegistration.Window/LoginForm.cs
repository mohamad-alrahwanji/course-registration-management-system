using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class LoginForm : Form
    {   
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = UserService.Login(usernameTextBox.Text, passwordTextBox.Text);

                Form dashboard;

                if (user.Role == "Administrator")
                {
                    dashboard = new AdminDashboardForm(user);
                }
                else
                {
                    dashboard = new StudentDashboardForm(user);
                }

                Hide();

                dashboard.ShowDialog(this);

                passwordTextBox.Clear();
                Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch
            {
                MessageBox.Show("An unknown error has occured. Please try again later.");
            }

        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }
    }
}
