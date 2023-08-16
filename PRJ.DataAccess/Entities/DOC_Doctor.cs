using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_Doctor
    {
        public DOC_Doctor()
        {
            DOC_DoctorAwards = new HashSet<DOC_DoctorAward>();
            DOC_DoctorLicenses = new HashSet<DOC_DoctorLicense>();
            DOC_DoctorReferences = new HashSet<DOC_DoctorReference>();
            DOC_DoctorSpecializations = new HashSet<DOC_DoctorSpecialization>();
            DOC_EducationDetails = new HashSet<DOC_EducationDetail>();
        }

        public long DoctorId { get; set; }
        public string? SecondaryEmail { get; set; }
        public string? SignatureURL { get; set; }
        public long? AccountNumber { get; set; }
        public string? AccountHolderName { get; set; }
        public string? BankName { get; set; }
        public string? BankLocation { get; set; }
        public bool? IsProfileApprovedByAdmin { get; set; }
        public string? AdminComment { get; set; }
        public string? PracticeAddress { get; set; }
        public int? ServiceRegionCountryId { get; set; }
        public int? ServiceRegionStateId { get; set; }
        public string? IBAN { get; set; }
        public bool? IsApproved { get; set; }
        public string? Reason { get; set; }
        public string? AddionalReason { get; set; }
        public string? StripeAccountId { get; set; }
        public DateTime ApprovalStatusDate { get; set; }

        public virtual SYS_User Doctor { get; set; } = null!;
        public virtual SYS_Country? ServiceRegionCountry { get; set; }
        public virtual SYS_State? ServiceRegionState { get; set; }
        public virtual ICollection<DOC_DoctorAward> DOC_DoctorAwards { get; set; }
        public virtual ICollection<DOC_DoctorLicense> DOC_DoctorLicenses { get; set; }
        public virtual ICollection<DOC_DoctorReference> DOC_DoctorReferences { get; set; }
        public virtual ICollection<DOC_DoctorSpecialization> DOC_DoctorSpecializations { get; set; }
        public virtual ICollection<DOC_EducationDetail> DOC_EducationDetails { get; set; }
    }
}
