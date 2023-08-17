using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class Patient
    {
        public Patient()
        {
            AmbulanceDetails = new HashSet<AmbulanceDetail>();
        }

        public int Id { get; set; }
        public string? PatientDiagosis { get; set; }
        public string? PrimaryConsultant { get; set; }
        public string? PatientEmergencyNumber { get; set; }
        public string? BriefDescription { get; set; }

        public virtual User IdNavigation { get; set; } = null!;
        public virtual ICollection<AmbulanceDetail> AmbulanceDetails { get; set; }
    }
}
