using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_DoctorFeedback
    {
        public long DoctorFeedbackId { get; set; }
        public long DoctorId { get; set; }
        public long PatientId { get; set; }
        public int? Rating { get; set; }
        public string? Feedback { get; set; }
        public long? AppointmentId { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual PAT_PatientAppointment? Appointment { get; set; }
        public virtual SYS_User Doctor { get; set; } = null!;
        public virtual SYS_User Patient { get; set; } = null!;
    }
}
