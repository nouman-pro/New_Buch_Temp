using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientLabTest
    {
        public long PatientLabTestId { get; set; }
        public long PatientAppointmentId { get; set; }
        public string? TestName { get; set; }
        public string? Reason { get; set; }
        public DateTime? RecommendationDate { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? LabTestUrl { get; set; }

        public virtual PAT_PatientAppointment PatientAppointment { get; set; } = null!;
    }
}
