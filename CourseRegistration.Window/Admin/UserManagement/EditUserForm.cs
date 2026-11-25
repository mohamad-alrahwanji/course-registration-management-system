using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class EditUserForm : Form
    {
        private readonly User? _user;

        public EditUserForm(User user)
        {
            InitializeComponent();

            _user = user;

            usernameTextBox.Text = _user.Username;
            fullNameTextBox.Text = _user.FullName;
            roleCombo.Text = _user.Role;
            isActiveCheckBox.Checked = _user.IsActive;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (_user == null) return;

            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            User user = new User
            {
                Id = _user.Id,
                Username = usernameTextBox.Text,
                FullName = fullNameTextBox.Text,
                Role = roleCombo.Text,
                IsActive = isActiveCheckBox.Checked
            };

            try
            {
                bool changesSaved = UserService.Edit(user, newPasswordTextBox.Text);

                if (changesSaved)
                {
                    MessageBox.Show("Changes saved successfully.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Could not save changes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ocurred: {ex.Message}");
            }
        }
    }
}
