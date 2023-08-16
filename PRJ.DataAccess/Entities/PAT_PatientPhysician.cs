using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientPhysician
    {
        public long PatientPhysicianId { get; set; }
        public long PatientId { get; set; }
        public string? FullName { get; set; }
        public int SpecialityId { get; set; }
        public string? Location { get; set; }
        public DateTime? LastVisitDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Notes { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual PAT_Patient Patient { get; set; } = null!;
        public virtual SYS_Speciality Speciality { get; set; } = null!;
    }
}
