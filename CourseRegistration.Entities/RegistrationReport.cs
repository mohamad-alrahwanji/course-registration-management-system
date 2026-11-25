using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistration.Entities
{
    public record RegistrationReport
    {
        public string StudentNumber { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
    }
}
