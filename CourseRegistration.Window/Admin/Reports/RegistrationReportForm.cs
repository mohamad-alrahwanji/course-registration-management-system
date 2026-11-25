using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class RegistrationReportForm : Form
    {
        public RegistrationReportForm()
        {
            InitializeComponent();

            courseCombo.DataSource = CourseService.GetAll();
            courseCombo.DisplayMember = "CourseName";

            ReportsGridView.DataSource = ClassService.GetAll();
            ReportsGridView.Columns["Id"]?.Visible = false;
            ReportsGridView.Columns["CourseId"]?.Visible = false;
            ReportsGridView.Columns["IsActive"]?.Visible = false;

        }

        private void CourseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course? course = courseCombo.SelectedItem as Course;

            if (course == null)
            {
                ReportsGridView.DataSource = ClassService.GetAll();
                classCombo.DataSource = null;
                return;
            }

            List<Class> classes = ClassService.GetByCourseId(course.Id);

            ReportsGridView.DataSource = classes;

            List<string> classNames = new List<string>();

            foreach (Class courseClass in classes)
            {
                if (!classNames.Contains(courseClass.ClassName))
                {
                    classNames.Add(courseClass.ClassName);
                }
            }

            classCombo.DataSource = classNames;
            classCombo.SelectedIndex = -1;
        }

        private void viewRegisteredStudentsButton_Click(object sender, EventArgs e)
        {
            Class? selectedClass = ReportsGridView.CurrentRow?.DataBoundItem as Class;

            if (selectedClass == null)
            {
                MessageBox.Show("Please select a class");
                return;
            }

            ClassRegistrationsForm classRegistrationsForm = new ClassRegistrationsForm(selectedClass);
            classRegistrationsForm.ShowDialog(this);
        }

        private void classCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course? selectedCourse = courseCombo.SelectedItem as Course;

            if (selectedCourse == null)
            {
                ReportsGridView.DataSource = ClassService.GetAll();
                return;
            }

            List<Class> classes = ClassService.GetByCourseId(selectedCourse.Id);

            if (classCombo.SelectedIndex == -1)
            {
                ReportsGridView.DataSource = classes;
                return;
            }

            List<Class> filteredClasses = new List<Class>();

            foreach (Class courseClass in classes)
            {
                if (courseClass.ClassName == classCombo.Text)
                {
                    filteredClasses.Add(courseClass);
                }
            }

            ReportsGridView.DataSource = filteredClasses;
        }
    }
}
