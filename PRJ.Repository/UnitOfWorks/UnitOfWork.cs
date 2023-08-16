using PRJ.DataAccess.Entities;

namespace PRJ.Repository.UnitOfWorks;
public class UnitOfWork : IDisposable, IUnitOfWork
{
    private bool disposed = false;
    private readonly MainContext _context;
    public UnitOfWork(MainContext _context)
    {
        this._context = _context;
    }
    #region System
    private IRepository<SYS_User> _userRepo;
    private IRepository<SYS_Login> _loginRepo;
    private IRepository<SYS_Language> _languageRepo;
    private IRepository<SYS_Country> _countryRepo;
    private IRepository<SYS_City> _cityRepo;
    private IRepository<SYS_State> _stateRepo;
    private IRepository<SYS_Medicine> _medicineRepo;
    private IRepository<SYS_Lookup> _lookupRepo;
    private IRepository<SYS_UserLang> _userLanguageRepo;
    private IRepository<SYS_ForgetPassword> _forgetPasswordRepo;
    private IRepository<SYS_Speciality> _specialityRepo;
    private IRepository<SYS_SubSpeciality> _subSpecialityRepo;
    private IRepository<SYS_Inbox> _inboxRepo;
    private IRepository<SYS_Chat> _chatRepo;

    private IRepository<SYS_Plan> _planRepo;
    IRepository<Chat_Attachment> _chat_AttachmentRepo;

    private IRepository<SYS_PlanSubscription> _userSubscriptionRepo;
    private IRepository<Sys_PushNotification> _pushNotificationRepo;


    #endregion

    #region Patient
    //  private IRepository<PAT_PatientFamilyMember> _familyMemberRepo;
    private IRepository<PAT_PatientPhysician> _patientPhysicianRepo;
    private IRepository<PAT_PatientLabResult> _patientLabResultRepo;
    private IRepository<PAT_PatientEmergencyContact> _patientEmergencyContactRepo;
    private IRepository<PAT_PatientGuardian> _patientGuardianRepo;
    private IRepository<PAT_MotherExaminationDetail> _motherExaminationDetailRepo;
    private IRepository<PAT_BirthHistoryDetail> _birthHistoryDetailRepo;
    private IRepository<PAT_DoctorObservation> _doctorObservationRepo;

    private IRepository<PAT_PatientAllergyHistory> _allergyHistoryRepo;
    private IRepository<PAT_PatientSocialHistory> _socialHistoryRepo;
    private IRepository<PAT_PatientSurgeryHistory> _surgeryHistoryRepo;
    private IRepository<PAT_PatientCurrentMedication> _patientCurrentMedicationRepo;
    private IRepository<PAT_PatientIllnessHistory> _patientIllnessHistoryRepo;
    private IRepository<PAT_Avatar> _avatarRepo;
    private IRepository<PAT_AvatarCoordinate> _avatarCoordinateRepo;

    private IRepository<PAT_SoapNote> _soapNoteRepo;
    private IRepository<PAT_PatientVital> _patientVitalRepo;

    private IRepository<PAT_PatientLabTest> _patientLabTestRepo;
    private IRepository<PAT_Patient> _patientRepo;

    private IRepository<PatientTransaction> _patientTransactionRepo;
    private IRepository<PAT_FollowUpReason> _pat_FollowUpReasonRepo;
    #endregion

    #region Doctor
    private IRepository<DOC_CommunityForm> _communityFormRepo;
    private IRepository<DOC_DoctorReference> _doctorReferenceRepo;
    private IRepository<DOC_DoctorAward> _doctorAwardRepo;
    private IRepository<DOC_DoctorSpecialization> _doctorSpecializationRepo;
    private IRepository<DOC_Doctor> _docRepo;
    private IRepository<DOC_EducationDetail> _docEducationRepo;
    private IRepository<DOC_DoctorLicense> _docLicenseRepo;
    private IRepository<DOC_SlotDivision> _docSlotDivisionRepo;
    private IRepository<DOC_Slot> _docSlotRepo;
    private IRepository<DOC_AvailableDay> _availableDayRepo;
    private IRepository<DOC_DoctorFeedback> _feedbackRepo;
    private IRepository<DOC_Subscription> _doctorSubscriptionRepo;
    private IRepository<BlogLike> _blogLikeRepo;

    private IRepository<BlogComment> _blogCommentRepo;
    private IRepository<SecureChat> _secureChatRepo;
    private IRepository<AttachedFile> _attachedFileRepo;
    private IRepository<ReceivedUser> _receivedUserRepo;
    private IRepository<CommunityFormAttachedFile> _communityFormAttachedFileRepo;
    IRepository<SYS_Staff> _staffRepo;

    IRepository<Staff_Schedule> _staffScheduleRepo;
    IRepository<SYS_Role> _sys_RoleRepo;
    IRepository<SYS_Permission> _sys_PermissionRepo;
    IRepository<SYS_Menu> _sys_MenuRepo;
    #endregion

    #region Appointment

    private IRepository<PAT_PatientAppointment> _appointmentRepo;


    #endregion

    #region AppointmentImplementaion

    public IRepository<PAT_PatientAppointment> AppointmentRepo
    {
        get
        {
            return _appointmentRepo ??
                (_appointmentRepo = new Repository<PAT_PatientAppointment>(_context));
        }
    }
    #endregion

    #region DoctorImplementaion
    public IRepository<CommunityFormAttachedFile> CommunityFormAttachedFileRepo
    {
        get
        {
            return _communityFormAttachedFileRepo ??
                (_communityFormAttachedFileRepo = new Repository<CommunityFormAttachedFile>(_context));
        }
    }
    public IRepository<AttachedFile> AttachedFileRepo
    {
        get
        {
            return _attachedFileRepo ??
                (_attachedFileRepo = new Repository<AttachedFile>(_context));
        }
    }
    public IRepository<ReceivedUser> ReceivedUserRepo
    {
        get
        {
            return _receivedUserRepo ??
                (_receivedUserRepo = new Repository<ReceivedUser>(_context));
        }
    }

    public IRepository<SecureChat> SecureChatRepo
    {
        get
        {
            return _secureChatRepo ??
                (_secureChatRepo = new Repository<SecureChat>(_context));
        }
    }
    public IRepository<DOC_CommunityForm> CommunityFormRepo
    {
        get
        {
            return _communityFormRepo ??
                (_communityFormRepo = new Repository<DOC_CommunityForm>(_context));
        }
    }
    public IRepository<BlogLike> BlogLikeRepo
    {
        get
        {
            return _blogLikeRepo ??
                (_blogLikeRepo = new Repository<BlogLike>(_context));
        }
    }
    public IRepository<BlogComment> BlogCommentRepo
    {
        get
        {
            return _blogCommentRepo ??
                (_blogCommentRepo = new Repository<BlogComment>(_context));
        }
    }
    public IRepository<DOC_Subscription> DoctorSubscriptionRepo
    {
        get
        {
            return _doctorSubscriptionRepo ??
                (_doctorSubscriptionRepo = new Repository<DOC_Subscription>(_context));
        }
    }
    public IRepository<DOC_DoctorFeedback> FeedbackRepo
    {
        get
        {
            return _feedbackRepo ??
                (_feedbackRepo = new Repository<DOC_DoctorFeedback>(_context));
        }
    }

    public IRepository<DOC_AvailableDay> AvailableDayRepo
    {
        get
        {
            return _availableDayRepo ??
                (_availableDayRepo = new Repository<DOC_AvailableDay>(_context));
        }
    }
    public IRepository<DOC_SlotDivision> DocSlotDivisionRepo
    {
        get
        {
            return _docSlotDivisionRepo ??
                (_docSlotDivisionRepo = new Repository<DOC_SlotDivision>(_context));
        }
    }
    public IRepository<DOC_Slot> DocSlotRepo
    {
        get
        {
            return _docSlotRepo ??
                (_docSlotRepo = new Repository<DOC_Slot>(_context));
        }
    }
    public IRepository<DOC_DoctorSpecialization> DoctorSpecializationRepo
    {
        get
        {
            return _doctorSpecializationRepo ??
                (_doctorSpecializationRepo = new Repository<DOC_DoctorSpecialization>(_context));
        }
    }
    public IRepository<DOC_DoctorAward> DoctorAwardRepo
    {
        get
        {
            return _doctorAwardRepo ??
                (_doctorAwardRepo = new Repository<DOC_DoctorAward>(_context));
        }
    }
    public IRepository<DOC_DoctorReference> DoctorReferenceRepo
    {
        get
        {
            return _doctorReferenceRepo ??
                (_doctorReferenceRepo = new Repository<DOC_DoctorReference>(_context));
        }
    }
    #endregion

    #region PatientImplementaion
    //public IRepository<PAT_PatientFamilyMember> FamilyMemberRepo
    //{
    //    get
    //    {
    //        return _familyMemberRepo ??
    //            (_familyMemberRepo = new Repository<PAT_PatientFamilyMember>(_context));
    //    }
    //}
    public IRepository<PatientTransaction> PatientTransactionRepo
    {
        get
        {
            return _patientTransactionRepo ??
                (_patientTransactionRepo = new Repository<PatientTransaction>(_context));
        }
    }

    public IRepository<PAT_Patient> PatientRepo
    {
        get
        {
            return _patientRepo ??
                (_patientRepo = new Repository<PAT_Patient>(_context));
        }
    }

    public IRepository<PAT_PatientLabTest> PatientLabTestRepo
    {
        get
        {
            return _patientLabTestRepo ??
                (_patientLabTestRepo = new Repository<PAT_PatientLabTest>(_context));
        }
    }

    public IRepository<PAT_DoctorObservation> DoctorObservationRepo
    {
        get
        {
            return _doctorObservationRepo ??
                (_doctorObservationRepo = new Repository<PAT_DoctorObservation>(_context));
        }
    }

    public IRepository<PAT_PatientVital> PatientVitalRepo
    {
        get
        {
            return _patientVitalRepo ??
                (_patientVitalRepo = new Repository<PAT_PatientVital>(_context));
        }
    }
    public IRepository<PAT_SoapNote> SoapNoteRepo
    {
        get
        {
            return _soapNoteRepo ??
                (_soapNoteRepo = new Repository<PAT_SoapNote>(_context));
        }
    }
    public IRepository<PAT_AvatarCoordinate> AvatarCoordinateRepo
    {
        get
        {
            return _avatarCoordinateRepo ??
                (_avatarCoordinateRepo = new Repository<PAT_AvatarCoordinate>(_context));
        }
    }
    public IRepository<PAT_Avatar> AvatarRepo
    {
        get
        {
            return _avatarRepo ??
                (_avatarRepo = new Repository<PAT_Avatar>(_context));
        }
    }

    public IRepository<PAT_PatientCurrentMedication> PatientCurrentMedicationRepo
    {
        get
        {
            return _patientCurrentMedicationRepo ??
                (_patientCurrentMedicationRepo = new Repository<PAT_PatientCurrentMedication>(_context));
        }
    }

    public IRepository<PAT_PatientIllnessHistory> PatientIllnessHistoryRepo
    {
        get
        {
            return _patientIllnessHistoryRepo ??
                (_patientIllnessHistoryRepo = new Repository<PAT_PatientIllnessHistory>(_context));
        }
    }

    public IRepository<PAT_PatientSurgeryHistory> SurgeryHistoryRepo
    {
        get
        {
            return _surgeryHistoryRepo ??
                (_surgeryHistoryRepo = new Repository<PAT_PatientSurgeryHistory>(_context));
        }
    }
    public IRepository<PAT_PatientSocialHistory> SocialHistoryRepo
    {
        get
        {
            return _socialHistoryRepo ??
                (_socialHistoryRepo = new Repository<PAT_PatientSocialHistory>(_context));
        }
    }

    public IRepository<PAT_PatientAllergyHistory> AllergyHistoryRepo
    {
        get
        {
            return _allergyHistoryRepo ??
                (_allergyHistoryRepo = new Repository<PAT_PatientAllergyHistory>(_context));
        }
    }
    public IRepository<PAT_BirthHistoryDetail> BirthHistoryDetailRepo
    {
        get
        {
            return _birthHistoryDetailRepo ??
                (_birthHistoryDetailRepo = new Repository<PAT_BirthHistoryDetail>(_context));
        }
    }
    public IRepository<PAT_MotherExaminationDetail> MotherExaminationDetailRepo
    {
        get
        {
            return _motherExaminationDetailRepo ??
                (_motherExaminationDetailRepo = new Repository<PAT_MotherExaminationDetail>(_context));
        }
    }
    public IRepository<PAT_PatientGuardian> PatientGuardianRepo
    {
        get
        {
            return _patientGuardianRepo ??
                (_patientGuardianRepo = new Repository<PAT_PatientGuardian>(_context));
        }
    }
    public IRepository<PAT_PatientEmergencyContact> PatientEmergencyContactRepo
    {
        get
        {
            return _patientEmergencyContactRepo ??
                (_patientEmergencyContactRepo = new Repository<PAT_PatientEmergencyContact>(_context));
        }
    }
    public IRepository<PAT_PatientLabResult> PatientLabResultRepo
    {
        get
        {
            return _patientLabResultRepo ??
                (_patientLabResultRepo = new Repository<PAT_PatientLabResult>(_context));
        }
    }
    public IRepository<PAT_PatientPhysician> PatientPhysicianRepo
    {
        get
        {
            return _patientPhysicianRepo ??
                (_patientPhysicianRepo = new Repository<PAT_PatientPhysician>(_context));
        }
    }
    #endregion

    public IRepository<PAT_FollowUpReason> PAT_FollowUpReasonRepo
    {
        get
        {
            return _pat_FollowUpReasonRepo ??
                (_pat_FollowUpReasonRepo = new Repository<PAT_FollowUpReason>(_context));
        }
    }



    public IRepository<Sys_PushNotification> PushNotificationRepo
    {
        get
        {
            return _pushNotificationRepo ??
                (_pushNotificationRepo = new Repository<Sys_PushNotification>(_context));
        }
    }

    public IRepository<SYS_Menu> SYS_MenuRepo
    {
        get
        {
            return _sys_MenuRepo ??
                (_sys_MenuRepo = new Repository<SYS_Menu>(_context));
        }
    }


    public IRepository<Chat_Attachment> Chat_AttachmentRepo
    {
        get
        {
            return _chat_AttachmentRepo ??
                (_chat_AttachmentRepo = new Repository<Chat_Attachment>(_context));
        }
    }
    public IRepository<SYS_Role> SYS_RoleRepo
    {
        get
        {
            return _sys_RoleRepo ??
                (_sys_RoleRepo = new Repository<SYS_Role>(_context));
        }
    }
    public IRepository<SYS_Permission> SYS_PermissionRepo
    {
        get
        {
            return _sys_PermissionRepo ??
                (_sys_PermissionRepo = new Repository<SYS_Permission>(_context));
        }
    }
    public IRepository<SYS_Staff> SYS_StaffRepo
    {
        get
        {
            return _staffRepo ??
                (_staffRepo = new Repository<SYS_Staff>(_context));
        }
    }
    public IRepository<Staff_Schedule> Staff_ScheduleRepo
    {
        get
        {
            return _staffScheduleRepo ??
                (_staffScheduleRepo = new Repository<Staff_Schedule>(_context));
        }
    }
    public IRepository<SYS_Plan> PlanRepo
    {
        get
        {
            return _planRepo ??
                (_planRepo = new Repository<SYS_Plan>(_context));
        }
    }
    public IRepository<SYS_PlanSubscription> UserSubscriptionRepo
    {
        get
        {
            return _userSubscriptionRepo ??
                (_userSubscriptionRepo = new Repository<SYS_PlanSubscription>(_context));
        }
    }
    public IRepository<SYS_Medicine> MedicineRepo
    {
        get
        {
            return _medicineRepo ??
                (_medicineRepo = new Repository<SYS_Medicine>(_context));
        }
    }



    public IRepository<SYS_User> UserRepo
    {
        get
        {
            if (_userRepo == null)
            {
                _userRepo = new Repository<SYS_User>(_context);
            }
            return _userRepo;
        }
    }
    public IRepository<SYS_Login> LoginRepo
    {
        get
        {
            if (_loginRepo == null)
            {
                _loginRepo = new Repository<SYS_Login>(_context);
            }
            return _loginRepo;
        }
    }
    public IRepository<SYS_Language> LanguageRepo
    {
        get
        {
            if (_languageRepo == null)
            {
                _languageRepo = new Repository<SYS_Language>(_context);
            }
            return _languageRepo;
        }
    }
    public IRepository<SYS_Country> CountryRepo
    {
        get
        {
            if (_countryRepo == null)
            {
                _countryRepo = new Repository<SYS_Country>(_context);
            }
            return _countryRepo;
        }
    }
    public IRepository<SYS_State> StateRepo
    {
        get
        {
            if (_stateRepo == null)
            {
                _stateRepo = new Repository<SYS_State>(_context);
            }
            return _stateRepo;
        }
    }
    public IRepository<SYS_City> CityRepo
    {
        get
        {
            if (_cityRepo == null)
            {
                _cityRepo = new Repository<SYS_City>(_context);
            }
            return _cityRepo;
        }
    }
    public IRepository<SYS_Lookup> LookupRepo
    {
        get
        {
            if (_lookupRepo == null)
            {
                _lookupRepo = new Repository<SYS_Lookup>(_context);
            }
            return _lookupRepo;
        }
    }
    public IRepository<SYS_UserLang> UserLanguageRepo
    {
        get
        {
            if (_userLanguageRepo == null)
            {
                _userLanguageRepo = new Repository<SYS_UserLang>(_context);
            }
            return _userLanguageRepo;
        }
    }
    public IRepository<SYS_ForgetPassword> ForgetPasswordRepo
    {
        get
        {
            if (_forgetPasswordRepo == null)
            {
                _forgetPasswordRepo = new Repository<SYS_ForgetPassword>(_context);
            }
            return _forgetPasswordRepo;
        }
    }

    public IRepository<DOC_Doctor> DocRepo
    {
        get
        {
            if (_docRepo == null)
            {
                _docRepo = new Repository<DOC_Doctor>(_context);
            }
            return _docRepo;
        }
    }


    public IRepository<DOC_EducationDetail> DocEducationRepo
    {
        get
        {
            if (_docEducationRepo == null)
            {
                _docEducationRepo = new Repository<DOC_EducationDetail>(_context);
            }
            return _docEducationRepo;
        }
    }
    public IRepository<DOC_DoctorLicense> DocLicenseRepo
    {
        get
        {
            if (_docLicenseRepo == null)
            {
                _docLicenseRepo = new Repository<DOC_DoctorLicense>(_context);
            }
            return _docLicenseRepo;
        }
    }
    public IRepository<SYS_Speciality> SpecialityRepo
    {
        get
        {
            if (_specialityRepo == null)
            {
                _specialityRepo = new Repository<SYS_Speciality>(_context);
            }
            return _specialityRepo;
        }
    }
    public IRepository<SYS_SubSpeciality> SubSpecialityRepo
    {
        get
        {
            if (_subSpecialityRepo == null)
            {
                _subSpecialityRepo = new Repository<SYS_SubSpeciality>(_context);
            }
            return _subSpecialityRepo;
        }
    }
    public IRepository<SYS_Inbox> InboxRepo
    {
        get
        {
            if (_inboxRepo == null)
            {
                _inboxRepo = new Repository<SYS_Inbox>(_context);
            }
            return _inboxRepo;
        }
    }
    public IRepository<SYS_Chat> ChatRepo
    {
        get
        {
            if (_chatRepo == null)
            {
                _chatRepo = new Repository<SYS_Chat>(_context);
            }
            return _chatRepo;
        }
    }
    public async Task<int> Save()
    {
        var res = await _context.SaveChangesAsync();
        return res;
    }

    public void Dispose()
    {
        this._context.Dispose();
    }
}
