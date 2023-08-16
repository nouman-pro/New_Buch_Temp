using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientMedication
    {
        public long PatientMedicationId { get; set; }
        public long PatientAppointmentId { get; set; }
        public int? MedicineId { get; set; }
        public int? FrequencyId { get; set; }
        public DateTime? DurationStartTime { get; set; }
        public DateTime? DurationEndTime { get; set; }
        public int? Unit { get; set; }
        public int? Dose { get; set; }
        public int? Refill { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SYS_Lookup? Frequency { get; set; }
        public virtual SYS_Medicine? Medicine { get; set; }
    }
}
