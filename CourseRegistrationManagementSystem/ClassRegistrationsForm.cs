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
    public partial class ClassRegistrationsForm : Form
    {
        private readonly RegistrationService _registrationService;
        private readonly Class _class;
        public ClassRegistrationsForm(RegistrationService registrationService, Class courseClass)
        {
            InitializeComponent();

            _registrationService = registrationService;
            _class = courseClass;

            registrationsGrid.DataSource = _registrationService.GetByClassId(_class.Id);
        }
    }
}
