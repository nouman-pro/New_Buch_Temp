using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_City
    {
        public SYS_City()
        {
            DOC_EducationDetails = new HashSet<DOC_EducationDetail>();
            PAT_PatientGuardians = new HashSet<PAT_PatientGuardian>();
            PAT_Patients = new HashSet<PAT_Patient>();
            SYS_Users = new HashSet<SYS_User>();
        }

        public int CityId { get; set; }
        public string Value { get; set; } = null!;
        public int StateId { get; set; }

        public virtual SYS_State State { get; set; } = null!;
        public virtual ICollection<DOC_EducationDetail> DOC_EducationDetails { get; set; }
        public virtual ICollection<PAT_PatientGuardian> PAT_PatientGuardians { get; set; }
        public virtual ICollection<PAT_Patient> PAT_Patients { get; set; }
        public virtual ICollection<SYS_User> SYS_Users { get; set; }
    }
}
