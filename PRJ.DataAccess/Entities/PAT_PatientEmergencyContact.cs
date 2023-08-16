using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientEmergencyContact
    {
        public long PatientEmergencyContactId { get; set; }
        public long PatientId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int RelationshipId { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual PAT_Patient Patient { get; set; } = null!;
        public virtual SYS_Lookup Relationship { get; set; } = null!;
    }
}
