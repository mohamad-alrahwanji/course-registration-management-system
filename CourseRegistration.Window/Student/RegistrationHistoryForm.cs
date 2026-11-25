using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class RegistrationHistoryForm : Form
    {
        private readonly Student _student;
        public RegistrationHistoryForm(Student student)
        {
            InitializeComponent();

            _student = student;

            myRegistrationsGrid.DataSource = RegistrationService.GetByStudentId(_student.Id);
            myRegistrationsGrid.Columns["Id"]?.Visible = false;
            myRegistrationsGrid.Columns["StudentId"]?.Visible = false;
            myRegistrationsGrid.Columns["ClassId"]?.Visible = false;
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

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool cancelled = RegistrationService.Cancel(selectedRegistration.Id);

                if (cancelled)
                {
                    MessageBox.Show("Registration cancelled successfully.");
                    myRegistrationsGrid.DataSource = RegistrationService.GetByStudentId(_student.Id);
                }
                else MessageBox.Show("Registration could not be cancelled.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error occured: {ex.Message}");
            }
        }
    }
}
