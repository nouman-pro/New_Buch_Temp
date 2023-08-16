using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_FollowUpReason
    {
        public long Id { get; set; }
        public long AppointmentId { get; set; }
        public string? FollowUpReason { get; set; }

        public virtual PAT_PatientAppointment Appointment { get; set; } = null!;
    }
}
