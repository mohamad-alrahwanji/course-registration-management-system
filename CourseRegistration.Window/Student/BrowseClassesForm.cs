using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class BrowseClassesForm : Form
    {
        private readonly Student _student;
        public BrowseClassesForm(Student student)
        {
            InitializeComponent();

            _student = student;

            availableClassesGrid.DataSource = ClassService.GetActive();
            availableClassesGrid.Columns["CourseId"]?.Visible = false;
            availableClassesGrid.Columns["IsActive"]?.Visible = false;

            myRegistrationsGrid.DataSource = RegistrationService.GetActiveByStudentId(student.Id);
            myRegistrationsGrid.Columns["Id"]?.Visible = false;
            myRegistrationsGrid.Columns["StudentId"]?.Visible = false;
            myRegistrationsGrid.Columns["ClassId"]?.Visible = false;

        }

        private void registerClassButton_Click(object sender, EventArgs e)
        {
            Class? selectedClass = availableClassesGrid.CurrentRow?.DataBoundItem as Class;

            if (selectedClass == null)
            {
                MessageBox.Show("Please select a class to register for.");
                return;
            }

            Registration registration = new Registration
            {
                StudentId = _student.Id,
                ClassId = selectedClass.Id,
                Schedule = selectedClass.Schedule
            };

            try
            {
                bool registered = RegistrationService.Add(registration);

                if (registered)
                {
                    MessageBox.Show("Class registered successfully.");
                    availableClassesGrid.DataSource = ClassService.SearchActive(searchClassTextBox.Text);
                    myRegistrationsGrid.DataSource = RegistrationService.GetActiveByStudentId(_student.Id);
                }

                else
                {
                    MessageBox.Show("Could not register for class.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error has occured: {ex.Message}");
            }
        }

        private void searchClassTextBox_TextChanged(object sender, EventArgs e)
        {
            availableClassesGrid.DataSource = ClassService.SearchActive(searchClassTextBox.Text);
        }

        private void CancelRegistrationButton_Click(object sender, EventArgs e)
        {
            Registration? selectedRegistration = myRegistrationsGrid.CurrentRow?.DataBoundItem as Registration;

            if (selectedRegistration == null)
            {
                MessageBox.Show("Please select a registration to cancel.");
                return;
            }

            DialogResult answer = MessageBox.Show("Are you sure you want to cancel this registration?", "Confirm Selection",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes) return;

            try
            {
                bool cancelled = RegistrationService.Cancel(selectedRegistration.Id);

                if (cancelled)
                {
                    MessageBox.Show("Registration cancelled successfully.");

                    myRegistrationsGrid.DataSource = RegistrationService.GetActiveByStudentId(_student.Id);

                    availableClassesGrid.DataSource = ClassService.SearchActive(searchClassTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Registration could not be cancelled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error occured: {ex.Message}");
            }
        }
    }
}
