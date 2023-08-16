using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientVital
    {
        public long PatientVitalId { get; set; }
        public long? PatientAppointmentId { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public int? SugarLevel { get; set; }
        public int HeartRate { get; set; }
        public int? BloodPressureSystolic { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? BloodPressureDiastolic { get; set; }
        public long? PatientId { get; set; }

        public virtual PAT_PatientAppointment? PatientAppointment { get; set; }
    }
}
