using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();

            usersGrid.DataSource = UserService.GetAll();

            DataGridViewColumn? passwordColumn = usersGrid.Columns["PasswordHash"];

            if (passwordColumn != null)
            {
                passwordColumn.Visible = false;
            }
        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {

            if (adminPasswordTextBox.Text != adminConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            User user = new User
            {
                Username = adminUsernameTextBox.Text,
                FullName = adminFullNameTextBox.Text,
                Role = "Administrator",
                IsActive = adminIsActiveCheckBox.Checked
            };

            try
            {
                bool added = UserService.Add(user, adminPasswordTextBox.Text);

                if (added)
                {
                    MessageBox.Show("Admin added successfully.");
                    usersGrid.DataSource = UserService.Search(userSearchTextBox.Text);
                }
                else MessageBox.Show("Admin could not be added.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            usersGrid.DataSource = UserService.Search(userSearchTextBox.Text);
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            User? selectedUser = usersGrid.CurrentRow?.DataBoundItem as User;

            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            if(selectedUser.Role == "Student")
            {
                MessageBox.Show("Student accounts must be edited from Student Management.");
                return;
            }

            EditUserForm editForm = new EditUserForm(selectedUser);
            DialogResult result = editForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                usersGrid.DataSource = UserService.Search(userSearchTextBox.Text);
            }

        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            User? selectedUser = usersGrid.CurrentRow?.DataBoundItem as User;

            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            if (selectedUser.Role == "Student")
            {
                MessageBox.Show("Student accounts must be deleted from Student Management.");
                return;
            }

            DialogResult answer = MessageBox.Show($"Are you sure you want to delete {selectedUser.Username}?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes) return;

            try
            {
                bool isDeleted = UserService.Delete(selectedUser);

                if (isDeleted)
                {
                    usersGrid.DataSource = UserService.Search(userSearchTextBox.Text);
                    MessageBox.Show("User has been deleted successfully.");
                }

                else MessageBox.Show("User could not be deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occured: {ex.Message}");
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = stdUsernameTextBox.Text,
                FullName = stdFullNameTextBox.Text,
                IsActive = stdIsActiveCheckBox.Checked
            };

            Student student = new Student
            {
                StudentNumber = studentNumberTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
            };

            try
            {
                bool added = StudentService.Add(user, student, stdPasswordTextBox.Text, stdConfirmPasswordTextBox.Text);

                if (added)
                {
                    MessageBox.Show("Student added successfully.");
                    usersGrid.DataSource = UserService.Search(userSearchTextBox.Text);
                }
                else MessageBox.Show("Student could not be added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
