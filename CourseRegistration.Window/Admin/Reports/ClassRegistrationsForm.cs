using CourseRegistration.BL.Services;
using CourseRegistration.Entities;

namespace CourseRegistration.Window
{
    public partial class ClassRegistrationsForm : Form
    {
        private readonly Class _class;
        public ClassRegistrationsForm(Class courseClass)
        {
            InitializeComponent();

            _class = courseClass;

            registrationsGrid.DataSource = RegistrationService.GetByClassId(_class.Id);
        }
    }
}
