using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_DoctorObservation
    {
        public long DoctorObservationId { get; set; }
        public long PatientAppointmentId { get; set; }
        public string? Description { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual PAT_PatientAppointment PatientAppointment { get; set; } = null!;
    }
}
