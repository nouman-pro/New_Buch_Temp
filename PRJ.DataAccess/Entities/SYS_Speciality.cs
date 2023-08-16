using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Speciality
    {
        public SYS_Speciality()
        {
            DOC_DoctorSpecializations = new HashSet<DOC_DoctorSpecialization>();
            PAT_PatientPhysicians = new HashSet<PAT_PatientPhysician>();
        }

        public int SpecialityId { get; set; }
        public string? Value { get; set; }

        public virtual ICollection<DOC_DoctorSpecialization> DOC_DoctorSpecializations { get; set; }
        public virtual ICollection<PAT_PatientPhysician> PAT_PatientPhysicians { get; set; }
    }
}
