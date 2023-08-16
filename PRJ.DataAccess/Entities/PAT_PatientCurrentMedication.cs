using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientCurrentMedication
    {
        public long PatientCurrentMedicationId { get; set; }
        public long PatientId { get; set; }
        public long? DoctorId { get; set; }
        public DateTime? PrescribedDate { get; set; }
        public DateTime? StartedUsing { get; set; }
        public int MedicineId { get; set; }
        public string? Reason { get; set; }
        public int DoseId { get; set; }
        public int DoseFrequencyId { get; set; }
        public string? DoctorName { get; set; }
        public string? DoctorContactNumber { get; set; }
        public string? Notes { get; set; }
        public int? RouteId { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? PatientAppointmentId { get; set; }

        public virtual SYS_User? Doctor { get; set; }
        public virtual SYS_Lookup Dose { get; set; } = null!;
        public virtual SYS_Lookup DoseFrequency { get; set; } = null!;
        public virtual SYS_Medicine Medicine { get; set; } = null!;
        public virtual PAT_Patient Patient { get; set; } = null!;
        public virtual PAT_PatientAppointment? PatientAppointment { get; set; }
        public virtual SYS_Lookup? Route { get; set; }
    }
}
