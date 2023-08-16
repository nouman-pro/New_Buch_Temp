using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientAppointment
    {
        public PAT_PatientAppointment()
        {
            DOC_DoctorFeedbacks = new HashSet<DOC_DoctorFeedback>();
            PAT_Avatars = new HashSet<PAT_Avatar>();
            PAT_DoctorObservations = new HashSet<PAT_DoctorObservation>();
            PAT_FollowUpReasons = new HashSet<PAT_FollowUpReason>();
            PAT_PatientCurrentMedications = new HashSet<PAT_PatientCurrentMedication>();
            PAT_PatientLabTests = new HashSet<PAT_PatientLabTest>();
            PAT_PatientVitals = new HashSet<PAT_PatientVital>();
            PAT_SoapNotes = new HashSet<PAT_SoapNote>();
        }

        public long AppointmentId { get; set; }
        public long? PatientId { get; set; }
        public long? DoctorId { get; set; }
        public long? SlotDivisionId { get; set; }
        public int? AppointmentStatusId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? AvailableDayId { get; set; }
        public int? AppointmentTypeId { get; set; }
        public string? OpenTokSessionId { get; set; }
        public bool IsFeedbackAdded { get; set; }

        public virtual SYS_Lookup? AppointmentStatus { get; set; }
        public virtual SYS_Lookup? AppointmentType { get; set; }
        public virtual DOC_AvailableDay? AvailableDay { get; set; }
        public virtual SYS_User? Doctor { get; set; }
        public virtual SYS_User? Patient { get; set; }
        public virtual ICollection<DOC_DoctorFeedback> DOC_DoctorFeedbacks { get; set; }
        public virtual ICollection<PAT_Avatar> PAT_Avatars { get; set; }
        public virtual ICollection<PAT_DoctorObservation> PAT_DoctorObservations { get; set; }
        public virtual ICollection<PAT_FollowUpReason> PAT_FollowUpReasons { get; set; }
        public virtual ICollection<PAT_PatientCurrentMedication> PAT_PatientCurrentMedications { get; set; }
        public virtual ICollection<PAT_PatientLabTest> PAT_PatientLabTests { get; set; }
        public virtual ICollection<PAT_PatientVital> PAT_PatientVitals { get; set; }
        public virtual ICollection<PAT_SoapNote> PAT_SoapNotes { get; set; }
    }
}
