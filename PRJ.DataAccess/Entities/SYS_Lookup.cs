using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Lookup
    {
        public SYS_Lookup()
        {
            DOC_AvailableDays = new HashSet<DOC_AvailableDay>();
            DOC_DoctorLicenses = new HashSet<DOC_DoctorLicense>();
            DOC_DoctorReferences = new HashSet<DOC_DoctorReference>();
            DOC_EducationDetails = new HashSet<DOC_EducationDetail>();
            DOC_SlotDurations = new HashSet<DOC_Slot>();
            DOC_SlotGaps = new HashSet<DOC_Slot>();
            DOC_SlotSlotTypes = new HashSet<DOC_Slot>();
            PAT_Avatars = new HashSet<PAT_Avatar>();
            PAT_BirthHistoryDetailDeliveryAndAnesthesiaTypes = new HashSet<PAT_BirthHistoryDetail>();
            PAT_BirthHistoryDetailInfantSexes = new HashSet<PAT_BirthHistoryDetail>();
            PAT_MotherExaminationDetailGynecologicalConditions = new HashSet<PAT_MotherExaminationDetail>();
            PAT_MotherExaminationDetailMenstrualPeriods = new HashSet<PAT_MotherExaminationDetail>();
            PAT_PatientAppointmentAppointmentStatuses = new HashSet<PAT_PatientAppointment>();
            PAT_PatientAppointmentAppointmentTypes = new HashSet<PAT_PatientAppointment>();
            PAT_PatientBloodGroups = new HashSet<PAT_Patient>();
            PAT_PatientCurrentMedicationDoseFrequencies = new HashSet<PAT_PatientCurrentMedication>();
            PAT_PatientCurrentMedicationDoses = new HashSet<PAT_PatientCurrentMedication>();
            PAT_PatientCurrentMedicationRoutes = new HashSet<PAT_PatientCurrentMedication>();
            PAT_PatientEmergencyContacts = new HashSet<PAT_PatientEmergencyContact>();
            PAT_PatientFamilyMembers = new HashSet<PAT_PatientFamilyMember>();
            PAT_PatientGuardians = new HashSet<PAT_PatientGuardian>();
            PAT_PatientMedications = new HashSet<PAT_PatientMedication>();
            PAT_PatientRelations = new HashSet<PAT_Patient>();
            PAT_PatientSurgeryHistories = new HashSet<PAT_PatientSurgeryHistory>();
            SYS_CouponDiscountTypes = new HashSet<SYS_Coupon>();
            SYS_CouponFrequencies = new HashSet<SYS_Coupon>();
            SYS_PlanDurations = new HashSet<SYS_Plan>();
            SYS_PlanPlanTypes = new HashSet<SYS_Plan>();
            SYS_Roles = new HashSet<SYS_Role>();
            SYS_Staffs = new HashSet<SYS_Staff>();
            SYS_UserGenders = new HashSet<SYS_User>();
            SYS_UserMaritalStatuses = new HashSet<SYS_User>();
            SYS_UserOTPMedia = new HashSet<SYS_User>();
            SYS_UserRoles = new HashSet<SYS_User>();
            SYS_UserTitles = new HashSet<SYS_User>();
            Staff_Schedules = new HashSet<Staff_Schedule>();
            Sys_PushNotifications = new HashSet<Sys_PushNotification>();
        }

        public int LookupId { get; set; }
        public string? Type { get; set; }
        public string? Text { get; set; }
        public string? Value { get; set; }
        public int? Order { get; set; }

        public virtual ICollection<DOC_AvailableDay> DOC_AvailableDays { get; set; }
        public virtual ICollection<DOC_DoctorLicense> DOC_DoctorLicenses { get; set; }
        public virtual ICollection<DOC_DoctorReference> DOC_DoctorReferences { get; set; }
        public virtual ICollection<DOC_EducationDetail> DOC_EducationDetails { get; set; }
        public virtual ICollection<DOC_Slot> DOC_SlotDurations { get; set; }
        public virtual ICollection<DOC_Slot> DOC_SlotGaps { get; set; }
        public virtual ICollection<DOC_Slot> DOC_SlotSlotTypes { get; set; }
        public virtual ICollection<PAT_Avatar> PAT_Avatars { get; set; }
        public virtual ICollection<PAT_BirthHistoryDetail> PAT_BirthHistoryDetailDeliveryAndAnesthesiaTypes { get; set; }
        public virtual ICollection<PAT_BirthHistoryDetail> PAT_BirthHistoryDetailInfantSexes { get; set; }
        public virtual ICollection<PAT_MotherExaminationDetail> PAT_MotherExaminationDetailGynecologicalConditions { get; set; }
        public virtual ICollection<PAT_MotherExaminationDetail> PAT_MotherExaminationDetailMenstrualPeriods { get; set; }
        public virtual ICollection<PAT_PatientAppointment> PAT_PatientAppointmentAppointmentStatuses { get; set; }
        public virtual ICollection<PAT_PatientAppointment> PAT_PatientAppointmentAppointmentTypes { get; set; }
        public virtual ICollection<PAT_Patient> PAT_PatientBloodGroups { get; set; }
        public virtual ICollection<PAT_PatientCurrentMedication> PAT_PatientCurrentMedicationDoseFrequencies { get; set; }
        public virtual ICollection<PAT_PatientCurrentMedication> PAT_PatientCurrentMedicationDoses { get; set; }
        public virtual ICollection<PAT_PatientCurrentMedication> PAT_PatientCurrentMedicationRoutes { get; set; }
        public virtual ICollection<PAT_PatientEmergencyContact> PAT_PatientEmergencyContacts { get; set; }
        public virtual ICollection<PAT_PatientFamilyMember> PAT_PatientFamilyMembers { get; set; }
        public virtual ICollection<PAT_PatientGuardian> PAT_PatientGuardians { get; set; }
        public virtual ICollection<PAT_PatientMedication> PAT_PatientMedications { get; set; }
        public virtual ICollection<PAT_Patient> PAT_PatientRelations { get; set; }
        public virtual ICollection<PAT_PatientSurgeryHistory> PAT_PatientSurgeryHistories { get; set; }
        public virtual ICollection<SYS_Coupon> SYS_CouponDiscountTypes { get; set; }
        public virtual ICollection<SYS_Coupon> SYS_CouponFrequencies { get; set; }
        public virtual ICollection<SYS_Plan> SYS_PlanDurations { get; set; }
        public virtual ICollection<SYS_Plan> SYS_PlanPlanTypes { get; set; }
        public virtual ICollection<SYS_Role> SYS_Roles { get; set; }
        public virtual ICollection<SYS_Staff> SYS_Staffs { get; set; }
        public virtual ICollection<SYS_User> SYS_UserGenders { get; set; }
        public virtual ICollection<SYS_User> SYS_UserMaritalStatuses { get; set; }
        public virtual ICollection<SYS_User> SYS_UserOTPMedia { get; set; }
        public virtual ICollection<SYS_User> SYS_UserRoles { get; set; }
        public virtual ICollection<SYS_User> SYS_UserTitles { get; set; }
        public virtual ICollection<Staff_Schedule> Staff_Schedules { get; set; }
        public virtual ICollection<Sys_PushNotification> Sys_PushNotifications { get; set; }
    }
}
