using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_Patient
    {
        public PAT_Patient()
        {
            InverseParent = new HashSet<PAT_Patient>();
            PAT_Avatars = new HashSet<PAT_Avatar>();
            PAT_BirthHistoryDetails = new HashSet<PAT_BirthHistoryDetail>();
            PAT_MotherExaminationDetails = new HashSet<PAT_MotherExaminationDetail>();
            PAT_PatientAllergyHistories = new HashSet<PAT_PatientAllergyHistory>();
            PAT_PatientCurrentMedications = new HashSet<PAT_PatientCurrentMedication>();
            PAT_PatientEmergencyContacts = new HashSet<PAT_PatientEmergencyContact>();
            PAT_PatientGuardians = new HashSet<PAT_PatientGuardian>();
            PAT_PatientIllnessHistories = new HashSet<PAT_PatientIllnessHistory>();
            PAT_PatientLabResults = new HashSet<PAT_PatientLabResult>();
            PAT_PatientPhysicians = new HashSet<PAT_PatientPhysician>();
            PAT_PatientSocialHistories = new HashSet<PAT_PatientSocialHistory>();
            PAT_PatientSurgeryHistories = new HashSet<PAT_PatientSurgeryHistory>();
        }

        public long PatientId { get; set; }
        public string? SecondaryAddress { get; set; }
        public long? SecondaryZipCode { get; set; }
        public int? SecondaryCountryId { get; set; }
        public int? BloodGroupId { get; set; }
        public bool? IsVaccinated { get; set; }
        public int? SecondaryStateId { get; set; }
        public int? SecondaryCityId { get; set; }
        public string? StripeCustomerId { get; set; }
        public bool IsCardAdded { get; set; }
        public int TotalAppointments { get; set; }
        public int FamilyMembersAllowed { get; set; }
        public bool IsParent { get; set; }
        public bool IsAdmin { get; set; }
        public long? ParentId { get; set; }
        public int? RelationId { get; set; }

        public virtual SYS_Lookup? BloodGroup { get; set; }
        public virtual PAT_Patient? Parent { get; set; }
        public virtual SYS_User Patient { get; set; } = null!;
        public virtual SYS_Lookup? Relation { get; set; }
        public virtual SYS_City? SecondaryCity { get; set; }
        public virtual SYS_Country? SecondaryCountry { get; set; }
        public virtual SYS_State? SecondaryState { get; set; }
        public virtual ICollection<PAT_Patient> InverseParent { get; set; }
        public virtual ICollection<PAT_Avatar> PAT_Avatars { get; set; }
        public virtual ICollection<PAT_BirthHistoryDetail> PAT_BirthHistoryDetails { get; set; }
        public virtual ICollection<PAT_MotherExaminationDetail> PAT_MotherExaminationDetails { get; set; }
        public virtual ICollection<PAT_PatientAllergyHistory> PAT_PatientAllergyHistories { get; set; }
        public virtual ICollection<PAT_PatientCurrentMedication> PAT_PatientCurrentMedications { get; set; }
        public virtual ICollection<PAT_PatientEmergencyContact> PAT_PatientEmergencyContacts { get; set; }
        public virtual ICollection<PAT_PatientGuardian> PAT_PatientGuardians { get; set; }
        public virtual ICollection<PAT_PatientIllnessHistory> PAT_PatientIllnessHistories { get; set; }
        public virtual ICollection<PAT_PatientLabResult> PAT_PatientLabResults { get; set; }
        public virtual ICollection<PAT_PatientPhysician> PAT_PatientPhysicians { get; set; }
        public virtual ICollection<PAT_PatientSocialHistory> PAT_PatientSocialHistories { get; set; }
        public virtual ICollection<PAT_PatientSurgeryHistory> PAT_PatientSurgeryHistories { get; set; }
    }
}
