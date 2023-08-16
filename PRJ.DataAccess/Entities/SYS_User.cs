using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_User
    {
        public SYS_User()
        {
            BlogComments = new HashSet<BlogComment>();
            BlogLikes = new HashSet<BlogLike>();
            DOC_CommunityForms = new HashSet<DOC_CommunityForm>();
            DOC_DoctorFeedbackDoctors = new HashSet<DOC_DoctorFeedback>();
            DOC_DoctorFeedbackPatients = new HashSet<DOC_DoctorFeedback>();
            DOC_Slots = new HashSet<DOC_Slot>();
            DOC_SubscriptionDoctors = new HashSet<DOC_Subscription>();
            DOC_SubscriptionPatients = new HashSet<DOC_Subscription>();
            PAT_Avatars = new HashSet<PAT_Avatar>();
            PAT_PatientAppointmentDoctors = new HashSet<PAT_PatientAppointment>();
            PAT_PatientAppointmentPatients = new HashSet<PAT_PatientAppointment>();
            PAT_PatientCurrentMedications = new HashSet<PAT_PatientCurrentMedication>();
            PAT_PatientFamilyMemberParents = new HashSet<PAT_PatientFamilyMember>();
            PAT_PatientFamilyMemberUsers = new HashSet<PAT_PatientFamilyMember>();
            PatientTransactions = new HashSet<PatientTransaction>();
            ReceivedUsers = new HashSet<ReceivedUser>();
            SYS_ChatFromUsers = new HashSet<SYS_Chat>();
            SYS_ChatToUsers = new HashSet<SYS_Chat>();
            SYS_InboxDoctorUsers = new HashSet<SYS_Inbox>();
            SYS_InboxPatientUsers = new HashSet<SYS_Inbox>();
            SYS_Logins = new HashSet<SYS_Login>();
            SYS_PlanSubscriptions = new HashSet<SYS_PlanSubscription>();
            SYS_Roles = new HashSet<SYS_Role>();
            SYS_UserLangs = new HashSet<SYS_UserLang>();
            SYS_UserLanguages = new HashSet<SYS_UserLanguage>();
            SecureChats = new HashSet<SecureChat>();
            Sys_PushNotifications = new HashSet<Sys_PushNotification>();
        }

        public long UserId { get; set; }
        public string? ProfilePicture { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int? TitleId { get; set; }
        public string Address { get; set; } = null!;
        public long? ZipCode { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public int? GenderId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? MaritalStatusId { get; set; }
        public int RoleId { get; set; }
        public bool? IsActive { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int OTPMediumId { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public bool IsOnBoardingCompleted { get; set; }

        public virtual SYS_City? City { get; set; }
        public virtual SYS_Country? Country { get; set; }
        public virtual SYS_Lookup? Gender { get; set; }
        public virtual SYS_Lookup? MaritalStatus { get; set; }
        public virtual SYS_Lookup OTPMedium { get; set; } = null!;
        public virtual SYS_Lookup Role { get; set; } = null!;
        public virtual SYS_State? State { get; set; }
        public virtual SYS_Lookup? Title { get; set; }
        public virtual DOC_Doctor? DOC_Doctor { get; set; }
        public virtual PAT_Patient? PAT_Patient { get; set; }
        public virtual SYS_Staff? SYS_Staff { get; set; }
        public virtual ICollection<BlogComment> BlogComments { get; set; }
        public virtual ICollection<BlogLike> BlogLikes { get; set; }
        public virtual ICollection<DOC_CommunityForm> DOC_CommunityForms { get; set; }
        public virtual ICollection<DOC_DoctorFeedback> DOC_DoctorFeedbackDoctors { get; set; }
        public virtual ICollection<DOC_DoctorFeedback> DOC_DoctorFeedbackPatients { get; set; }
        public virtual ICollection<DOC_Slot> DOC_Slots { get; set; }
        public virtual ICollection<DOC_Subscription> DOC_SubscriptionDoctors { get; set; }
        public virtual ICollection<DOC_Subscription> DOC_SubscriptionPatients { get; set; }
        public virtual ICollection<PAT_Avatar> PAT_Avatars { get; set; }
        public virtual ICollection<PAT_PatientAppointment> PAT_PatientAppointmentDoctors { get; set; }
        public virtual ICollection<PAT_PatientAppointment> PAT_PatientAppointmentPatients { get; set; }
        public virtual ICollection<PAT_PatientCurrentMedication> PAT_PatientCurrentMedications { get; set; }
        public virtual ICollection<PAT_PatientFamilyMember> PAT_PatientFamilyMemberParents { get; set; }
        public virtual ICollection<PAT_PatientFamilyMember> PAT_PatientFamilyMemberUsers { get; set; }
        public virtual ICollection<PatientTransaction> PatientTransactions { get; set; }
        public virtual ICollection<ReceivedUser> ReceivedUsers { get; set; }
        public virtual ICollection<SYS_Chat> SYS_ChatFromUsers { get; set; }
        public virtual ICollection<SYS_Chat> SYS_ChatToUsers { get; set; }
        public virtual ICollection<SYS_Inbox> SYS_InboxDoctorUsers { get; set; }
        public virtual ICollection<SYS_Inbox> SYS_InboxPatientUsers { get; set; }
        public virtual ICollection<SYS_Login> SYS_Logins { get; set; }
        public virtual ICollection<SYS_PlanSubscription> SYS_PlanSubscriptions { get; set; }
        public virtual ICollection<SYS_Role> SYS_Roles { get; set; }
        public virtual ICollection<SYS_UserLang> SYS_UserLangs { get; set; }
        public virtual ICollection<SYS_UserLanguage> SYS_UserLanguages { get; set; }
        public virtual ICollection<SecureChat> SecureChats { get; set; }
        public virtual ICollection<Sys_PushNotification> Sys_PushNotifications { get; set; }
    }
}
