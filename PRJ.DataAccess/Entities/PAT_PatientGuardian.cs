using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientGuardian
    {
        public long PatientGuardianId { get; set; }
        public long PatientId { get; set; }
        public string? FullName { get; set; }
        public int RelationshipId { get; set; }
        public string? WorkContact { get; set; }
        public string? HomeContact { get; set; }
        public int CountryId { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public long? ZipCode { get; set; }
        public string? Address { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }

        public virtual SYS_City? CityNavigation { get; set; }
        public virtual SYS_Country Country { get; set; } = null!;
        public virtual PAT_Patient Patient { get; set; } = null!;
        public virtual SYS_Lookup Relationship { get; set; } = null!;
        public virtual SYS_State? StateNavigation { get; set; }
    }
}
