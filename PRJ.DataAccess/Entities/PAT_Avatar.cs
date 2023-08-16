using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_Avatar
    {
        public PAT_Avatar()
        {
            PAT_AvatarCoordinates = new HashSet<PAT_AvatarCoordinate>();
        }

        public long AvatarId { get; set; }
        public long? DoctorId { get; set; }
        public long? PatientId { get; set; }
        public long? PatientAppointmentId { get; set; }
        public int? AppointmentTypeId { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? AvatarReason { get; set; }

        public virtual SYS_Lookup? AppointmentType { get; set; }
        public virtual SYS_User? Doctor { get; set; }
        public virtual PAT_Patient? Patient { get; set; }
        public virtual PAT_PatientAppointment? PatientAppointment { get; set; }
        public virtual ICollection<PAT_AvatarCoordinate> PAT_AvatarCoordinates { get; set; }
    }
}
