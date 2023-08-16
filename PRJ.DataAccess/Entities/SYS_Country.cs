using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Country
    {
        public SYS_Country()
        {
            DOC_DoctorAwards = new HashSet<DOC_DoctorAward>();
            DOC_DoctorLicenses = new HashSet<DOC_DoctorLicense>();
            DOC_Doctors = new HashSet<DOC_Doctor>();
            PAT_PatientGuardians = new HashSet<PAT_PatientGuardian>();
            PAT_Patients = new HashSet<PAT_Patient>();
            SYS_States = new HashSet<SYS_State>();
            SYS_Users = new HashSet<SYS_User>();
        }

        public int CountryId { get; set; }
        public string? Name { get; set; }
        public string? PhoneCode { get; set; }

        public virtual ICollection<DOC_DoctorAward> DOC_DoctorAwards { get; set; }
        public virtual ICollection<DOC_DoctorLicense> DOC_DoctorLicenses { get; set; }
        public virtual ICollection<DOC_Doctor> DOC_Doctors { get; set; }
        public virtual ICollection<PAT_PatientGuardian> PAT_PatientGuardians { get; set; }
        public virtual ICollection<PAT_Patient> PAT_Patients { get; set; }
        public virtual ICollection<SYS_State> SYS_States { get; set; }
        public virtual ICollection<SYS_User> SYS_Users { get; set; }
    }
}
