using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_DoctorLicense
    {
        public long LicenseId { get; set; }
        public long DoctorId { get; set; }
        public string? LicenseNumber { get; set; }
        public int LicenseTypeId { get; set; }
        public DateTime? LicenseIssueDate { get; set; }
        public DateTime? LicenseExpiryDate { get; set; }
        public int CountryId { get; set; }
        public string? LicenseDocumentURL { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SYS_Country Country { get; set; } = null!;
        public virtual DOC_Doctor Doctor { get; set; } = null!;
        public virtual SYS_Lookup LicenseType { get; set; } = null!;
    }
}
