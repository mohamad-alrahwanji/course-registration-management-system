using CourseRegistration.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseRegistration.Models;

namespace CourseRegistrationManagementSystem
{
    public partial class RegistrationHistoryForm : Form
    {
        private readonly RegistrationService _registrationService;
        private readonly Student _student;
        public RegistrationHistoryForm(RegistrationService registrationService, Student student)
        {
            InitializeComponent();

            _registrationService = registrationService;
            _student = student;

            myRegistrationsGrid.DataSource = _registrationService.GetByStudentId(_student.Id);
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
                bool cancelled = _registrationService.Cancel(selectedRegistration.Id);

                if (cancelled)
                {
                    MessageBox.Show("Registration cancelled successfully.");
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
