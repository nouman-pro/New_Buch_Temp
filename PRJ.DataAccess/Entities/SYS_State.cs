using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_State
    {
        public SYS_State()
        {
            DOC_Doctors = new HashSet<DOC_Doctor>();
            DOC_EducationDetails = new HashSet<DOC_EducationDetail>();
            PAT_PatientGuardians = new HashSet<PAT_PatientGuardian>();
            PAT_Patients = new HashSet<PAT_Patient>();
            SYS_Cities = new HashSet<SYS_City>();
            SYS_Users = new HashSet<SYS_User>();
        }

        public int StateId { get; set; }
        public string? Value { get; set; }
        public int CountryId { get; set; }

        public virtual SYS_Country Country { get; set; } = null!;
        public virtual ICollection<DOC_Doctor> DOC_Doctors { get; set; }
        public virtual ICollection<DOC_EducationDetail> DOC_EducationDetails { get; set; }
        public virtual ICollection<PAT_PatientGuardian> PAT_PatientGuardians { get; set; }
        public virtual ICollection<PAT_Patient> PAT_Patients { get; set; }
        public virtual ICollection<SYS_City> SYS_Cities { get; set; }
        public virtual ICollection<SYS_User> SYS_Users { get; set; }
    }
}
