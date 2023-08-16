using PRJ.DataAccess.Entities;

namespace PRJ.Repository.UnitOfWorks;
public interface IUnitOfWork
{
    IRepository<SYS_User> UserRepo { get; }
    IRepository<SYS_Medicine> MedicineRepo { get; }
    IRepository<SYS_Login> LoginRepo { get; }
    IRepository<SYS_Language> LanguageRepo { get; }
    IRepository<SYS_Country> CountryRepo { get; }
    IRepository<SYS_City> CityRepo { get; }
    IRepository<SYS_State> StateRepo { get; }
    IRepository<SYS_Lookup> LookupRepo { get; }
    IRepository<SYS_UserLang> UserLanguageRepo { get; }
    IRepository<SYS_ForgetPassword> ForgetPasswordRepo { get; }
    IRepository<DOC_DoctorReference> DoctorReferenceRepo { get; }
    IRepository<DOC_DoctorAward> DoctorAwardRepo { get; }
    IRepository<DOC_DoctorSpecialization> DoctorSpecializationRepo { get; }
    IRepository<DOC_Doctor> DocRepo { get; }
    IRepository<DOC_EducationDetail> DocEducationRepo { get; }
    IRepository<DOC_DoctorLicense> DocLicenseRepo { get; }
    IRepository<DOC_DoctorFeedback> FeedbackRepo { get; }

    IRepository<DOC_SlotDivision> DocSlotDivisionRepo { get; }
    IRepository<DOC_Slot> DocSlotRepo { get; }
    IRepository<DOC_AvailableDay> AvailableDayRepo { get; }

    IRepository<PAT_DoctorObservation> DoctorObservationRepo { get; }
    IRepository<PAT_PatientPhysician> PatientPhysicianRepo { get; }
    IRepository<PAT_PatientLabResult> PatientLabResultRepo { get; }
    IRepository<SYS_Speciality> SpecialityRepo { get; }
    IRepository<SYS_SubSpeciality> SubSpecialityRepo { get; }

    IRepository<PAT_PatientEmergencyContact> PatientEmergencyContactRepo { get; }
    IRepository<PAT_PatientGuardian> PatientGuardianRepo { get; }
    IRepository<PAT_MotherExaminationDetail> MotherExaminationDetailRepo { get; }
    IRepository<PAT_BirthHistoryDetail> BirthHistoryDetailRepo { get; }
    IRepository<PAT_PatientAllergyHistory> AllergyHistoryRepo { get; }
    IRepository<PAT_PatientSocialHistory> SocialHistoryRepo { get; }
    IRepository<PAT_PatientSurgeryHistory> SurgeryHistoryRepo { get; }
    IRepository<PAT_PatientCurrentMedication> PatientCurrentMedicationRepo { get; }
    IRepository<PAT_PatientIllnessHistory> PatientIllnessHistoryRepo { get; }
    IRepository<PAT_PatientAppointment> AppointmentRepo { get; }

    IRepository<PAT_Avatar> AvatarRepo { get; }
    IRepository<PAT_AvatarCoordinate> AvatarCoordinateRepo { get; }

    IRepository<PAT_SoapNote> SoapNoteRepo { get; }
    IRepository<PAT_PatientVital> PatientVitalRepo { get; }
    IRepository<PAT_PatientLabTest> PatientLabTestRepo { get; }
    IRepository<SYS_Inbox> InboxRepo { get; }
    IRepository<SYS_Chat> ChatRepo { get; }

    IRepository<SYS_Plan> PlanRepo { get; }

    IRepository<SYS_PlanSubscription> UserSubscriptionRepo { get; }

    IRepository<PAT_Patient> PatientRepo { get; }

    IRepository<DOC_CommunityForm> CommunityFormRepo { get; }

    IRepository<PatientTransaction> PatientTransactionRepo { get; }

    IRepository<DOC_Subscription> DoctorSubscriptionRepo { get; }
    IRepository<BlogLike> BlogLikeRepo { get; }

    IRepository<BlogComment> BlogCommentRepo { get; }
    IRepository<SecureChat> SecureChatRepo { get; }
    IRepository<AttachedFile> AttachedFileRepo { get; }
    IRepository<ReceivedUser> ReceivedUserRepo { get; }
    IRepository<CommunityFormAttachedFile> CommunityFormAttachedFileRepo { get; }

    IRepository<SYS_Staff> SYS_StaffRepo { get; }

    IRepository<Staff_Schedule> Staff_ScheduleRepo { get; }

    IRepository<SYS_Role> SYS_RoleRepo { get; }
    IRepository<SYS_Permission> SYS_PermissionRepo { get; }

    IRepository<SYS_Menu> SYS_MenuRepo { get; }

    IRepository<Chat_Attachment> Chat_AttachmentRepo { get; }

    IRepository<Sys_PushNotification> PushNotificationRepo { get; }

    IRepository<PAT_FollowUpReason> PAT_FollowUpReasonRepo { get; }

    Task<int> Save();
}
