using CourseRegistration.BusinessLogic;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseRegistrationManagementSystem
{
    public partial class StudentManagementForm : Form
    {
        private readonly StudentService _studentService;

        public StudentManagementForm(StudentService studentService)
        {
            InitializeComponent();
            _studentService = studentService;
            studentsGrid.DataSource = _studentService.GetAll();
            studentsGrid.Columns["UserId"]?.Visible = false;
        }

        private void searchStudentsTextBox_TextChanged(object sender, EventArgs e)
        {
            studentsGrid.DataSource = _studentService.Search(studentsSearchTextBox.Text);
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            Student? selectedStudent = studentsGrid.CurrentRow?.DataBoundItem as Student;

            if (selectedStudent == null)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            DialogResult answer = MessageBox.Show($"Are you sure you want to delete {selectedStudent.FullName}'s account?", "Confirm deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool isDeleted = _studentService.Delete(selectedStudent);

                if (isDeleted)
                {
                    studentsGrid.DataSource = _studentService.Search(studentsSearchTextBox.Text);
                    MessageBox.Show("Student and login account deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Student could not be deleted. Refresh and try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            Student? selectedStudent = studentsGrid.CurrentRow?.DataBoundItem as Student;

            if (selectedStudent == null)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }

            EditStudentForm editForm = new EditStudentForm(selectedStudent, _studentService);
            DialogResult result = editForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                studentsGrid.DataSource = _studentService.Search(studentsSearchTextBox.Text);
            }
        }
    }
}
