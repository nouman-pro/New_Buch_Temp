using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRJ.DataAccess.Entities
{
    public partial class MainContext : DbContext
    {
        public MainContext()
        {
        }

        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttachedFile> AttachedFiles { get; set; } = null!;
        public virtual DbSet<BlogComment> BlogComments { get; set; } = null!;
        public virtual DbSet<BlogLike> BlogLikes { get; set; } = null!;
        public virtual DbSet<Chat_Attachment> Chat_Attachments { get; set; } = null!;
        public virtual DbSet<CommunityFormAttachedFile> CommunityFormAttachedFiles { get; set; } = null!;
        public virtual DbSet<DOC_AvailableDay> DOC_AvailableDays { get; set; } = null!;
        public virtual DbSet<DOC_CommunityForm> DOC_CommunityForms { get; set; } = null!;
        public virtual DbSet<DOC_Doctor> DOC_Doctors { get; set; } = null!;
        public virtual DbSet<DOC_DoctorAward> DOC_DoctorAwards { get; set; } = null!;
        public virtual DbSet<DOC_DoctorFeedback> DOC_DoctorFeedbacks { get; set; } = null!;
        public virtual DbSet<DOC_DoctorLicense> DOC_DoctorLicenses { get; set; } = null!;
        public virtual DbSet<DOC_DoctorReference> DOC_DoctorReferences { get; set; } = null!;
        public virtual DbSet<DOC_DoctorSpecialization> DOC_DoctorSpecializations { get; set; } = null!;
        public virtual DbSet<DOC_EducationDetail> DOC_EducationDetails { get; set; } = null!;
        public virtual DbSet<DOC_Slot> DOC_Slots { get; set; } = null!;
        public virtual DbSet<DOC_SlotDivision> DOC_SlotDivisions { get; set; } = null!;
        public virtual DbSet<DOC_Subscription> DOC_Subscriptions { get; set; } = null!;
        public virtual DbSet<PAT_Avatar> PAT_Avatars { get; set; } = null!;
        public virtual DbSet<PAT_AvatarCoordinate> PAT_AvatarCoordinates { get; set; } = null!;
        public virtual DbSet<PAT_BirthHistoryDetail> PAT_BirthHistoryDetails { get; set; } = null!;
        public virtual DbSet<PAT_DoctorObservation> PAT_DoctorObservations { get; set; } = null!;
        public virtual DbSet<PAT_FollowUpReason> PAT_FollowUpReasons { get; set; } = null!;
        public virtual DbSet<PAT_MotherExaminationDetail> PAT_MotherExaminationDetails { get; set; } = null!;
        public virtual DbSet<PAT_Patient> PAT_Patients { get; set; } = null!;
        public virtual DbSet<PAT_PatientAllergyHistory> PAT_PatientAllergyHistories { get; set; } = null!;
        public virtual DbSet<PAT_PatientAppointment> PAT_PatientAppointments { get; set; } = null!;
        public virtual DbSet<PAT_PatientCurrentMedication> PAT_PatientCurrentMedications { get; set; } = null!;
        public virtual DbSet<PAT_PatientEmergencyContact> PAT_PatientEmergencyContacts { get; set; } = null!;
        public virtual DbSet<PAT_PatientFamilyMember> PAT_PatientFamilyMembers { get; set; } = null!;
        public virtual DbSet<PAT_PatientGuardian> PAT_PatientGuardians { get; set; } = null!;
        public virtual DbSet<PAT_PatientIllnessHistory> PAT_PatientIllnessHistories { get; set; } = null!;
        public virtual DbSet<PAT_PatientLabResult> PAT_PatientLabResults { get; set; } = null!;
        public virtual DbSet<PAT_PatientLabTest> PAT_PatientLabTests { get; set; } = null!;
        public virtual DbSet<PAT_PatientMedication> PAT_PatientMedications { get; set; } = null!;
        public virtual DbSet<PAT_PatientPhysician> PAT_PatientPhysicians { get; set; } = null!;
        public virtual DbSet<PAT_PatientSocialHistory> PAT_PatientSocialHistories { get; set; } = null!;
        public virtual DbSet<PAT_PatientSurgeryHistory> PAT_PatientSurgeryHistories { get; set; } = null!;
        public virtual DbSet<PAT_PatientUsedCoupon> PAT_PatientUsedCoupons { get; set; } = null!;
        public virtual DbSet<PAT_PatientVital> PAT_PatientVitals { get; set; } = null!;
        public virtual DbSet<PAT_SoapNote> PAT_SoapNotes { get; set; } = null!;
        public virtual DbSet<PAT_SubscribedBlog> PAT_SubscribedBlogs { get; set; } = null!;
        public virtual DbSet<PatientTransaction> PatientTransactions { get; set; } = null!;
        public virtual DbSet<ReceivedUser> ReceivedUsers { get; set; } = null!;
        public virtual DbSet<SYS_Chat> SYS_Chats { get; set; } = null!;
        public virtual DbSet<SYS_City> SYS_Cities { get; set; } = null!;
        public virtual DbSet<SYS_Country> SYS_Countries { get; set; } = null!;
        public virtual DbSet<SYS_Coupon> SYS_Coupons { get; set; } = null!;
        public virtual DbSet<SYS_ForgetPassword> SYS_ForgetPasswords { get; set; } = null!;
        public virtual DbSet<SYS_Inbox> SYS_Inboxes { get; set; } = null!;
        public virtual DbSet<SYS_LabTest> SYS_LabTests { get; set; } = null!;
        public virtual DbSet<SYS_Language> SYS_Languages { get; set; } = null!;
        public virtual DbSet<SYS_Login> SYS_Logins { get; set; } = null!;
        public virtual DbSet<SYS_Lookup> SYS_Lookups { get; set; } = null!;
        public virtual DbSet<SYS_Medicine> SYS_Medicines { get; set; } = null!;
        public virtual DbSet<SYS_Menu> SYS_Menus { get; set; } = null!;
        public virtual DbSet<SYS_Payment> SYS_Payments { get; set; } = null!;
        public virtual DbSet<SYS_Permission> SYS_Permissions { get; set; } = null!;
        public virtual DbSet<SYS_Plan> SYS_Plans { get; set; } = null!;
        public virtual DbSet<SYS_PlanSubscription> SYS_PlanSubscriptions { get; set; } = null!;
        public virtual DbSet<SYS_Role> SYS_Roles { get; set; } = null!;
        public virtual DbSet<SYS_Speciality> SYS_Specialities { get; set; } = null!;
        public virtual DbSet<SYS_Staff> SYS_Staffs { get; set; } = null!;
        public virtual DbSet<SYS_State> SYS_States { get; set; } = null!;
        public virtual DbSet<SYS_SubSpeciality> SYS_SubSpecialities { get; set; } = null!;
        public virtual DbSet<SYS_User> SYS_Users { get; set; } = null!;
        public virtual DbSet<SYS_UserLang> SYS_UserLangs { get; set; } = null!;
        public virtual DbSet<SYS_UserLanguage> SYS_UserLanguages { get; set; } = null!;
        public virtual DbSet<SecureChat> SecureChats { get; set; } = null!;
        public virtual DbSet<Staff_Schedule> Staff_Schedules { get; set; } = null!;
        public virtual DbSet<Sys_PushNotification> Sys_PushNotifications { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=128.199.54.14;Database=IntelliHealth_Dev;User Id=intellihealth-admin; Password=intellihealth_@dmin!2;encrypt=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttachedFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.Property(e => e.AttachedFileURL).HasMaxLength(500);

                entity.HasOne(d => d.SecureChat)
                    .WithMany(p => p.AttachedFiles)
                    .HasForeignKey(d => d.SecureChatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttachedFiles_SecureChat");
            });

            modelBuilder.Entity<BlogComment>(entity =>
            {
                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.CommunityForm)
                    .WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.CommunityFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogComments_DOC_CommunityForm");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_BlogComments_BlogComments");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogComments_SYS_Users");
            });

            modelBuilder.Entity<BlogLike>(entity =>
            {
                entity.HasKey(e => e.BlogLikedId)
                    .HasName("PK_BlogLikeAndComments");

                entity.HasOne(d => d.CommunityForm)
                    .WithMany(p => p.BlogLikes)
                    .HasForeignKey(d => d.CommunityFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogLikeAndComments_DOC_CommunityForm");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.BlogLikes)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogLikeAndComments_SYS_Users");
            });

            modelBuilder.Entity<Chat_Attachment>(entity =>
            {
                entity.HasKey(e => e.ChatAttachmentId);

                entity.Property(e => e.AttachmentsUrl).HasMaxLength(500);

                entity.HasOne(d => d.Chat)
                    .WithMany(p => p.Chat_Attachments)
                    .HasForeignKey(d => d.ChatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_Attachments_SYS_Chats");

                entity.HasOne(d => d.Inbox)
                    .WithMany(p => p.Chat_Attachments)
                    .HasForeignKey(d => d.InboxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_Attachments_SYS_Inboxes");
            });

            modelBuilder.Entity<CommunityFormAttachedFile>(entity =>
            {
                entity.HasKey(e => e.BlogImgId);

                entity.Property(e => e.KeyName).HasMaxLength(500);

                entity.HasOne(d => d.CommunityForm)
                    .WithMany(p => p.CommunityFormAttachedFiles)
                    .HasForeignKey(d => d.CommunityFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommunityFormAttachedFiles_DOC_CommunityForm");
            });

            modelBuilder.Entity<DOC_AvailableDay>(entity =>
            {
                entity.HasKey(e => e.AvailableDayId);

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SlotCreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.DOC_AvailableDays)
                    .HasForeignKey(d => d.DayId)
                    .HasConstraintName("FK_DOC_AvailableDays_SYS_Lookups");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.DOC_AvailableDays)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK_DOC_AvailableDays_DOC_Slots");
            });

            modelBuilder.Entity<DOC_CommunityForm>(entity =>
            {
                entity.ToTable("DOC_CommunityForm");

                entity.Property(e => e.BlockedReason).HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ImgURL).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DOC_CommunityForms)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOC_CommunityForm_SYS_Users");
            });

            modelBuilder.Entity<DOC_Doctor>(entity =>
            {
                entity.HasKey(e => e.DoctorId)
                    .HasName("PK__DOC_Doct__2DC00EBF11AF2EF2");

                entity.Property(e => e.DoctorId).ValueGeneratedNever();

                entity.Property(e => e.AccountHolderName).HasMaxLength(50);

                entity.Property(e => e.AddionalReason).HasMaxLength(500);

                entity.Property(e => e.AdminComment).HasMaxLength(500);

                entity.Property(e => e.ApprovalStatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BankLocation).HasMaxLength(250);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.IBAN).HasMaxLength(100);

                entity.Property(e => e.IsProfileApprovedByAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.PracticeAddress).HasMaxLength(250);

                entity.Property(e => e.Reason).HasMaxLength(250);

                entity.Property(e => e.SecondaryEmail).HasMaxLength(100);

                entity.Property(e => e.SignatureURL).HasMaxLength(250);

                entity.Property(e => e.StripeAccountId).HasMaxLength(200);

                entity.HasOne(d => d.Doctor)
                    .WithOne(p => p.DOC_Doctor)
                    .HasForeignKey<DOC_Doctor>(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOC_Doctors_UserId_PK_SYS_Users_UserId");

                entity.HasOne(d => d.ServiceRegionCountry)
                    .WithMany(p => p.DOC_Doctors)
                    .HasForeignKey(d => d.ServiceRegionCountryId)
                    .HasConstraintName("FK_DoctorsCountries_CountryId");

                entity.HasOne(d => d.ServiceRegionState)
                    .WithMany(p => p.DOC_Doctors)
                    .HasForeignKey(d => d.ServiceRegionStateId)
                    .HasConstraintName("FK_DoctorsStates_StateId");
            });

            modelBuilder.Entity<DOC_DoctorAward>(entity =>
            {
                entity.HasKey(e => e.DoctorAwardId)
                    .HasName("PK__DOC_Doct__2EB97AB94957735C");

                entity.Property(e => e.AwardDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Institute).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.DOC_DoctorAwards)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_DoctorAwardsCountries_CountryId");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DOC_DoctorAwards)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorAwardsDoctors_DoctorId");
            });

            modelBuilder.Entity<DOC_DoctorFeedback>(entity =>
            {
                entity.HasKey(e => e.DoctorFeedbackId)
                    .HasName("PK__DOC_Doct__380A1FB893E5F971");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Feedback).HasMaxLength(1000);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.DOC_DoctorFeedbacks)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK_DOC_DoctorFeedbacks_PAT_PatientAppointments");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DOC_DoctorFeedbackDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DOC_DoctorFeedbackPatients)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DOC_DoctorLicense>(entity =>
            {
                entity.HasKey(e => e.LicenseId)
                    .HasName("PK__DOC_Doct__72D600829B84C13E");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LicenseDocumentURL).HasMaxLength(250);

                entity.Property(e => e.LicenseExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LicenseIssueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LicenseNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.DOC_DoctorLicenses)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorLicensesCountries_CountryId");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DOC_DoctorLicenses)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorLicensesDoctors_DoctorId");

                entity.HasOne(d => d.LicenseType)
                    .WithMany(p => p.DOC_DoctorLicenses)
                    .HasForeignKey(d => d.LicenseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorLicensesLookups_LicenseTypeId");
            });

            modelBuilder.Entity<DOC_DoctorReference>(entity =>
            {
                entity.HasKey(e => e.DoctorReferenceId)
                    .HasName("PK__DOC_Doct__1CE8D0A46288BE08");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ReferenceName).HasMaxLength(50);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DOC_DoctorReferences)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorReferencesDoctors_DoctorId");

                entity.HasOne(d => d.Relation)
                    .WithMany(p => p.DOC_DoctorReferences)
                    .HasForeignKey(d => d.RelationId)
                    .HasConstraintName("FK_DoctorReferencesLookups_RelationId");
            });

            modelBuilder.Entity<DOC_DoctorSpecialization>(entity =>
            {
                entity.HasKey(e => e.DoctorSpecializationId)
                    .HasName("PK__DOC_Doct__14F6ED4D9895AFF9");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DOC_DoctorSpecializations)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorSpecializationsDoctors_DoctorId");

                entity.HasOne(d => d.Specialization)
                    .WithMany(p => p.DOC_DoctorSpecializations)
                    .HasForeignKey(d => d.SpecializationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorSpecializations_PK_Specializations_SpecializationId");
            });

            modelBuilder.Entity<DOC_EducationDetail>(entity =>
            {
                entity.HasKey(e => e.EducationDetailId)
                    .HasName("PK__DOC_Educ__1897449A930031BE");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DegreeTitle).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Institute).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.DOC_EducationDetails)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_EducationDetailsCities_CityId");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DOC_EducationDetails)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationDetailsDoctors_DoctorId");

                entity.HasOne(d => d.EducationType)
                    .WithMany(p => p.DOC_EducationDetails)
                    .HasForeignKey(d => d.EducationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationDetailsLookup_EducationTypeId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.DOC_EducationDetails)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_EducationDetailsStates_StateId");
            });

            modelBuilder.Entity<DOC_Slot>(entity =>
            {
                entity.HasKey(e => e.SlotId);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DOC_Slots)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_DOC_Slots_SYS_Users");

                entity.HasOne(d => d.Duration)
                    .WithMany(p => p.DOC_SlotDurations)
                    .HasForeignKey(d => d.DurationId);

                entity.HasOne(d => d.Gap)
                    .WithMany(p => p.DOC_SlotGaps)
                    .HasForeignKey(d => d.GapId);

                entity.HasOne(d => d.SlotType)
                    .WithMany(p => p.DOC_SlotSlotTypes)
                    .HasForeignKey(d => d.SlotTypeId)
                    .HasConstraintName("FK_DOC_Slots_SYS_Lookups");
            });

            modelBuilder.Entity<DOC_SlotDivision>(entity =>
            {
                entity.HasKey(e => e.SlotDivisionId)
                    .HasName("PK__DOC_Slot__806DA1FCDBA8C2E9");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SlotEndTime).HasMaxLength(50);

                entity.Property(e => e.SlotStartTime).HasMaxLength(50);

                entity.HasOne(d => d.AvailableDay)
                    .WithMany(p => p.DOC_SlotDivisions)
                    .HasForeignKey(d => d.AvailableDayId)
                    .HasConstraintName("FK_DOC_SlotDivisions_DOC_AvailableDays");
            });

            modelBuilder.Entity<DOC_Subscription>(entity =>
            {
                entity.HasKey(e => e.SubscribeId);

                entity.ToTable("DOC_Subscription");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DOC_SubscriptionDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOC_Subscription_SYS_Users_Doctor");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DOC_SubscriptionPatients)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOC_Subscription_SYS_Users_Patient");
            });

            modelBuilder.Entity<PAT_Avatar>(entity =>
            {
                entity.HasKey(e => e.AvatarId)
                    .HasName("PK__PAT_Avat__4811D66A5D3D7A3E");

                entity.Property(e => e.AvatarReason).HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.AppointmentType)
                    .WithMany(p => p.PAT_Avatars)
                    .HasForeignKey(d => d.AppointmentTypeId)
                    .HasConstraintName("FK_AvatarsLookups_AppointmentTypeId");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.PAT_Avatars)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_PAT_Avatars_SYS_Users");

                entity.HasOne(d => d.PatientAppointment)
                    .WithMany(p => p.PAT_Avatars)
                    .HasForeignKey(d => d.PatientAppointmentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PAT_Avatars_PAT_PatientAppointments");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_Avatars)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_PatientsAvatars_PatientId");
            });

            modelBuilder.Entity<PAT_AvatarCoordinate>(entity =>
            {
                entity.HasKey(e => e.AvatarCoordinateId)
                    .HasName("PK__PAT_Avat__2788AD370B17753C");

                entity.Property(e => e.Text).HasMaxLength(250);

                entity.HasOne(d => d.Avatar)
                    .WithMany(p => p.PAT_AvatarCoordinates)
                    .HasForeignKey(d => d.AvatarId)
                    .HasConstraintName("FK_AvatarCoordinatesAvatar_AvatarId");
            });

            modelBuilder.Entity<PAT_BirthHistoryDetail>(entity =>
            {
                entity.HasKey(e => e.BirthHistoryDetailId)
                    .HasName("PK__PAT_Birt__80EC3B156BE31AC5");

                entity.Property(e => e.ChildName).HasMaxLength(50);

                entity.Property(e => e.Complication).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryPlace).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MonthYear).HasColumnType("smalldatetime");

                entity.HasOne(d => d.DeliveryAndAnesthesiaType)
                    .WithMany(p => p.PAT_BirthHistoryDetailDeliveryAndAnesthesiaTypes)
                    .HasForeignKey(d => d.DeliveryAndAnesthesiaTypeId)
                    .HasConstraintName("FK_BirthHistoryDetailsLookups_DeliveryAndAnesthesiaTypeId");

                entity.HasOne(d => d.InfantSex)
                    .WithMany(p => p.PAT_BirthHistoryDetailInfantSexes)
                    .HasForeignKey(d => d.InfantSexId)
                    .HasConstraintName("FK_BirthHistoryDetailsLookups_InfantSexId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_BirthHistoryDetails)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientsBirthHistoryDetails_PatientId");
            });

            modelBuilder.Entity<PAT_DoctorObservation>(entity =>
            {
                entity.HasKey(e => e.DoctorObservationId)
                    .HasName("PK__PAT_Doct__04F2D15350755538");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.PatientAppointment)
                    .WithMany(p => p.PAT_DoctorObservations)
                    .HasForeignKey(d => d.PatientAppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_DoctorObservations_PAT_PatientAppointments");
            });

            modelBuilder.Entity<PAT_FollowUpReason>(entity =>
            {
                entity.ToTable("PAT_FollowUpReason");

                entity.Property(e => e.FollowUpReason).HasMaxLength(1000);

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.PAT_FollowUpReasons)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK_PAT_FollowUpReason_PAT_PatientAppointments");
            });

            modelBuilder.Entity<PAT_MotherExaminationDetail>(entity =>
            {
                entity.HasKey(e => e.MotherExaminationDetailId)
                    .HasName("PK__PAT_Moth__19FF46509F0AE6A7");

                entity.Property(e => e.BreastExam).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExaminationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.KindOfContraception).HasMaxLength(50);

                entity.Property(e => e.Mammogram).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PapSmear).HasMaxLength(250);

                entity.HasOne(d => d.GynecologicalCondition)
                    .WithMany(p => p.PAT_MotherExaminationDetailGynecologicalConditions)
                    .HasForeignKey(d => d.GynecologicalConditionId)
                    .HasConstraintName("FK_MotherExaminationDetails_PK_Lookups_GynecologicalConditionId");

                entity.HasOne(d => d.MenstrualPeriod)
                    .WithMany(p => p.PAT_MotherExaminationDetailMenstrualPeriods)
                    .HasForeignKey(d => d.MenstrualPeriodId)
                    .HasConstraintName("FK_MotherExaminationDetailsLookups_MenstrualPeriodId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_MotherExaminationDetails)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientsMotherExaminationDetails_PatientId");
            });

            modelBuilder.Entity<PAT_Patient>(entity =>
            {
                entity.HasKey(e => e.PatientId)
                    .HasName("PK__PAT_Pati__970EC36641EA521E");

                entity.Property(e => e.PatientId).ValueGeneratedNever();

                entity.Property(e => e.SecondaryAddress).HasMaxLength(250);

                entity.Property(e => e.StripeCustomerId).HasMaxLength(250);

                entity.HasOne(d => d.BloodGroup)
                    .WithMany(p => p.PAT_PatientBloodGroups)
                    .HasForeignKey(d => d.BloodGroupId)
                    .HasConstraintName("FK_PatientsLookups_BloodGroupId");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_FamilyMembers");

                entity.HasOne(d => d.Patient)
                    .WithOne(p => p.PAT_Patient)
                    .HasForeignKey<PAT_Patient>(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientsUsers_UserId");

                entity.HasOne(d => d.Relation)
                    .WithMany(p => p.PAT_PatientRelations)
                    .HasForeignKey(d => d.RelationId);

                entity.HasOne(d => d.SecondaryCity)
                    .WithMany(p => p.PAT_Patients)
                    .HasForeignKey(d => d.SecondaryCityId)
                    .HasConstraintName("FK_Patients_PK_Cities_SecondaryCityId");

                entity.HasOne(d => d.SecondaryCountry)
                    .WithMany(p => p.PAT_Patients)
                    .HasForeignKey(d => d.SecondaryCountryId)
                    .HasConstraintName("FK_PatientsCountries_CountryId");

                entity.HasOne(d => d.SecondaryState)
                    .WithMany(p => p.PAT_Patients)
                    .HasForeignKey(d => d.SecondaryStateId)
                    .HasConstraintName("FK_Patients_PK_States_SecondaryStateId");
            });

            modelBuilder.Entity<PAT_PatientAllergyHistory>(entity =>
            {
                entity.HasKey(e => e.PatientAllergylHistoryId)
                    .HasName("PK__PAT_Pati__3652A26D412926AB");

                entity.Property(e => e.AllergyTo).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Medication).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.Reaction).HasMaxLength(100);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_PatientAllergyHistories)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientsPatientAllergyHistories_PatientId");
            });

            modelBuilder.Entity<PAT_PatientAppointment>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK__PAT_Pati__60720C276CAF08D2");

                entity.Property(e => e.AppointmentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OpenTokSessionId).HasMaxLength(4000);

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");

                entity.HasOne(d => d.AppointmentStatus)
                    .WithMany(p => p.PAT_PatientAppointmentAppointmentStatuses)
                    .HasForeignKey(d => d.AppointmentStatusId)
                    .HasConstraintName("FK_PAT_PatientAppointments_SYS_Lookups");

                entity.HasOne(d => d.AppointmentType)
                    .WithMany(p => p.PAT_PatientAppointmentAppointmentTypes)
                    .HasForeignKey(d => d.AppointmentTypeId)
                    .HasConstraintName("FK_PAT_PatientAppointments_SYS_Lookups1");

                entity.HasOne(d => d.AvailableDay)
                    .WithMany(p => p.PAT_PatientAppointments)
                    .HasForeignKey(d => d.AvailableDayId)
                    .HasConstraintName("FK_PAT_PatientAppointments_DOC_AvailableDays");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.PAT_PatientAppointmentDoctors)
                    .HasForeignKey(d => d.DoctorId);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_PatientAppointmentPatients)
                    .HasForeignKey(d => d.PatientId);
            });

            modelBuilder.Entity<PAT_PatientCurrentMedication>(entity =>
            {
                entity.HasKey(e => e.PatientCurrentMedicationId)
                    .HasName("PK__PAT_Pati__629F2D9B844B7347");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DoctorContactNumber).HasMaxLength(50);

                entity.Property(e => e.DoctorName).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PrescribedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Reason).HasMaxLength(250);

                entity.Property(e => e.StartedUsing).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.PAT_PatientCurrentMedications)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_PAT_PatientCurrentMedications_SYS_Users");

                entity.HasOne(d => d.DoseFrequency)
                    .WithMany(p => p.PAT_PatientCurrentMedicationDoseFrequencies)
                    .HasForeignKey(d => d.DoseFrequencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientCurrentMedications_SYS_Lookups");

                entity.HasOne(d => d.Dose)
                    .WithMany(p => p.PAT_PatientCurrentMedicationDoses)
                    .HasForeignKey(d => d.DoseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientCurrentMedications_SYS_Lookups1");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.PAT_PatientCurrentMedications)
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientCurrentMedications_SYS_Medicines");

                entity.HasOne(d => d.PatientAppointment)
                    .WithMany(p => p.PAT_PatientCurrentMedications)
                    .HasForeignKey(d => d.PatientAppointmentId)
                    .HasConstraintName("FK_PAT_PatientCurrentMedications_PAT_PatientAppointments");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_PatientCurrentMedications)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientCurrentMedications_PK_Patients_PatientId");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.PAT_PatientCurrentMedicationRoutes)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_PAT_PatientCurrentMedications_SYS_Lookups2");
            });

            modelBuilder.Entity<PAT_PatientEmergencyContact>(entity =>
            {
                entity.HasKey(e => e.PatientEmergencyContactId)
                    .HasName("PK__PAT_Pati__E2DA97D7A10607F4");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_PatientEmergencyContacts)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientEmergencyContacts_PK_Patients_PatientId");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.PAT_PatientEmergencyContacts)
                    .HasForeignKey(d => d.RelationshipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientEmergencyContactsLookups_RelationshipId");
            });

            modelBuilder.Entity<PAT_PatientFamilyMember>(entity =>
            {
                entity.HasKey(e => new { e.FamilyMemberId, e.ParentId, e.UserId });

                entity.Property(e => e.FamilyMemberId).ValueGeneratedOnAdd();

                entity.Property(e => e.IsAdmin).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.PAT_PatientFamilyMemberParents)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientFamilyMembers_SYS_Users_Parent");

                entity.HasOne(d => d.Relation)
                    .WithMany(p => p.PAT_PatientFamilyMembers)
                    .HasForeignKey(d => d.RelationId)
                    .HasConstraintName("FK_PAT_PatientFamilyMembers_SYS_Lookups");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PAT_PatientFamilyMemberUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientFamilyMembers_SYS_Users");
            });

            modelBuilder.Entity<PAT_PatientGuardian>(entity =>
            {
                entity.HasKey(e => e.PatientGuardianId)
                    .HasName("PK__PAT_Pati__7C9FAABFBDA786E7");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.HomeContact).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.WorkContact).HasMaxLength(50);

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.PAT_PatientGuardians)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_PatientGuardians_PK_Cities_CityId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PAT_PatientGuardians)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientGuardiansCountries_CountryId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_PatientGuardians)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientGuardians_PK_Patients_PatientId");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.PAT_PatientGuardians)
                    .HasForeignKey(d => d.RelationshipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientGuardiansLookups_RelationshipId");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.PAT_PatientGuardians)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_PatientGuardians_PK_States_StateId");
            });

            modelBuilder.Entity<PAT_PatientIllnessHistory>(entity =>
            {
                entity.HasKey(e => e.PatientIllnessHistoryId)
                    .HasName("PK__PAT_Pati__7B642E9643099A0B");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DiseaseName).HasMaxLength(50);

                entity.Property(e => e.Treatment).HasMaxLength(250);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_PatientIllnessHistories)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientIllnessHistories_PK_Patients_PatientId");
            });

            modelBuilder.Entity<PAT_PatientLabResult>(entity =>
            {
                entity.HasKey(e => e.PatientLabResultId)
                    .HasName("PK__PAT_Pati__23D641DC21C777A3");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LabTestDocumentURL).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Reason).HasMaxLength(250);

                entity.Property(e => e.TestDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_PatientLabResults)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientLabResults_PK_Patients_PatientId");
            });

            modelBuilder.Entity<PAT_PatientLabTest>(entity =>
            {
                entity.HasKey(e => e.PatientLabTestId)
                    .HasName("PK__PAT_Pati__9AC090A4A918CC44");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LabTestUrl).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Reason).HasMaxLength(500);

                entity.Property(e => e.RecommendationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TestName).HasMaxLength(100);

                entity.HasOne(d => d.PatientAppointment)
                    .WithMany(p => p.PAT_PatientLabTests)
                    .HasForeignKey(d => d.PatientAppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientLabTests_PAT_PatientAppointments");
            });

            modelBuilder.Entity<PAT_PatientMedication>(entity =>
            {
                entity.HasKey(e => e.PatientMedicationId)
                    .HasName("PK__PAT_Pati__B08C9294A003EC73");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DurationEndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.DurationStartTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Frequency)
                    .WithMany(p => p.PAT_PatientMedications)
                    .HasForeignKey(d => d.FrequencyId)
                    .HasConstraintName("FK_PatientMedicationsLookups_FrequencyId");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.PAT_PatientMedications)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK_PatientMedicationsMedicines_MedicineId");
            });

            modelBuilder.Entity<PAT_PatientPhysician>(entity =>
            {
                entity.HasKey(e => e.PatientPhysicianId)
                    .HasName("PK__PAT_Pati__62B86546D6D5D88E");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.LastVisitDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_PatientPhysicians)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientPhysicians_PK_Patients_PatientId");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.PAT_PatientPhysicians)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientPhysiciansLookups_SpecialityId");
            });

            modelBuilder.Entity<PAT_PatientSocialHistory>(entity =>
            {
                entity.HasKey(e => e.PatientSocialHistoryId)
                    .HasName("PK__PAT_Pati__1CCBE7CCD1F32B21");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_PatientSocialHistories)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientSocialHistories_PK_Patients_PatientId");
            });

            modelBuilder.Entity<PAT_PatientSurgeryHistory>(entity =>
            {
                entity.HasKey(e => e.PatientSurgerylHistoryId)
                    .HasName("PK__PAT_Pati__765ED120205D4561");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.Reason).HasMaxLength(250);

                entity.Property(e => e.SurgeonName).HasMaxLength(50);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PAT_PatientSurgeryHistories)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientSurgeryHistories_PK_Patients_PatientId");

                entity.HasOne(d => d.SurgeryType)
                    .WithMany(p => p.PAT_PatientSurgeryHistories)
                    .HasForeignKey(d => d.SurgeryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientSurgeryHistoriesLookups_SurgeryTypeId");
            });

            modelBuilder.Entity<PAT_PatientUsedCoupon>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Coupon)
                    .WithMany()
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientsUsedCouponsCoupons_CouponId");

                entity.HasOne(d => d.Patient)
                    .WithMany()
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientUsedCoupons_PK_Patients_PatientId");
            });

            modelBuilder.Entity<PAT_PatientVital>(entity =>
            {
                entity.HasKey(e => e.PatientVitalId)
                    .HasName("PK__PAT_Pati__09888DB0F7033EC9");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.PatientAppointment)
                    .WithMany(p => p.PAT_PatientVitals)
                    .HasForeignKey(d => d.PatientAppointmentId)
                    .HasConstraintName("FK_PAT_PatientVitals_PAT_PatientAppointments");
            });

            modelBuilder.Entity<PAT_SoapNote>(entity =>
            {
                entity.HasKey(e => e.SoapNoteId)
                    .HasName("PK__PAT_Soap__F44F92EA25EFDE87");

                entity.Property(e => e.Assessment).HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Objective).HasMaxLength(1000);

                entity.Property(e => e.Plan).HasMaxLength(1000);

                entity.Property(e => e.Subjective).HasMaxLength(1000);

                entity.HasOne(d => d.PatientAppointment)
                    .WithMany(p => p.PAT_SoapNotes)
                    .HasForeignKey(d => d.PatientAppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_SoapNotes_PAT_PatientAppointments");
            });

            modelBuilder.Entity<PAT_SubscribedBlog>(entity =>
            {
                entity.HasKey(e => new { e.BlogId, e.PatientId })
                    .HasName("PK_BlogIdPatientId");
            });

            modelBuilder.Entity<PatientTransaction>(entity =>
            {
                entity.HasKey(e => e.UserTransactionId);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SubscriptionId).HasMaxLength(500);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientTransactions)
                    .HasForeignKey(d => d.PatientId);
            });

            modelBuilder.Entity<ReceivedUser>(entity =>
            {
                entity.HasKey(e => e.ReceivedId);

                entity.HasOne(d => d.SecureChat)
                    .WithMany(p => p.ReceivedUsers)
                    .HasForeignKey(d => d.SecureChatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceivedUsers_SecureChat");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.ReceivedUsers)
                    .HasForeignKey(d => d.ToUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceivedUsers_To_Users");
            });

            modelBuilder.Entity<SYS_Chat>(entity =>
            {
                entity.HasKey(e => e.ChatId)
                    .HasName("PK__SYS_Chat__A9FBE7C6A699E48A");

                entity.Property(e => e.AttachedURL).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(500);

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.SYS_ChatFromUsers)
                    .HasForeignKey(d => d.FromUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatsUser_FromUserId");

                entity.HasOne(d => d.Inbox)
                    .WithMany(p => p.SYS_Chats)
                    .HasForeignKey(d => d.InboxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatsInboxes_InboxId");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.SYS_ChatToUsers)
                    .HasForeignKey(d => d.ToUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatsUser_ToUserId");
            });

            modelBuilder.Entity<SYS_City>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK__SYS_Citi__F2D21B76057341F3");

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.Value).HasMaxLength(100);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.SYS_Cities)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_Cities_SYS_States");
            });

            modelBuilder.Entity<SYS_Country>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__SYS_Coun__10D1609FC5CC5C53");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PhoneCode).HasMaxLength(50);
            });

            modelBuilder.Entity<SYS_Coupon>(entity =>
            {
                entity.HasKey(e => e.CouponId)
                    .HasName("PK__SYS_Coup__384AF1BAE2E6CA4E");

                entity.Property(e => e.CouponName).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.SYS_CouponDiscountTypes)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponsLookups_DiscountTypeId");

                entity.HasOne(d => d.Frequency)
                    .WithMany(p => p.SYS_CouponFrequencies)
                    .HasForeignKey(d => d.FrequencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponsLookups_FrequencyId");
            });

            modelBuilder.Entity<SYS_ForgetPassword>(entity =>
            {
                entity.HasKey(e => new { e.LoginId, e.Code })
                    .HasName("PK_LoginIdCode");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.SYS_ForgetPasswords)
                    .HasForeignKey(d => d.LoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoginsForgetPasswords_LoginId");
            });

            modelBuilder.Entity<SYS_Inbox>(entity =>
            {
                entity.HasKey(e => e.InboxId)
                    .HasName("PK__SYS_Inbo__61A99C6CB83613B8");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.DoctorUser)
                    .WithMany(p => p.SYS_InboxDoctorUsers)
                    .HasForeignKey(d => d.DoctorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inboxes_PK_Users_DoctorUserId");

                entity.HasOne(d => d.PatientUser)
                    .WithMany(p => p.SYS_InboxPatientUsers)
                    .HasForeignKey(d => d.PatientUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inboxes_PK_Users_PatientUserId");
            });

            modelBuilder.Entity<SYS_LabTest>(entity =>
            {
                entity.HasKey(e => e.LabTestId)
                    .HasName("PK__SYS_LabT__64D33925DD9AAC5A");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<SYS_Language>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PK__SYS_Lang__B93855AB3DBAE382");

                entity.Property(e => e.Value).HasMaxLength(250);
            });

            modelBuilder.Entity<SYS_Login>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PK__SYS_Logi__4DDA2818A26EFAF4");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.LastLoginDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OTP).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SYS_Logins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoginsUsers_UserId");
            });

            modelBuilder.Entity<SYS_Lookup>(entity =>
            {
                entity.HasKey(e => e.LookupId)
                    .HasName("PK__SYS_Look__6D8B9C4BD605FD55");

                entity.Property(e => e.Text).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<SYS_Medicine>(entity =>
            {
                entity.HasKey(e => e.MedicineId)
                    .HasName("PK__SYS_Medi__4F212890B72B5CFA");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<SYS_Menu>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK_Modules");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Menus_Menus");
            });

            modelBuilder.Entity<SYS_Payment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK__SYS_Paym__9B556A38BDCE1AEB");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SYS_Permission>(entity =>
            {
                entity.HasKey(e => e.PermissionId)
                    .HasName("PK_Permissions");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAllowed)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.SYS_Permissions)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permissions_Menus");
            });

            modelBuilder.Entity<SYS_Plan>(entity =>
            {
                entity.HasKey(e => e.PlanId)
                    .HasName("PK__SYS_Plan__755C22B735930A20");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PlanFeature).HasMaxLength(1000);

                entity.Property(e => e.StripePlanId).HasMaxLength(250);

                entity.Property(e => e.StripePlanPriceId).HasMaxLength(250);

                entity.HasOne(d => d.Duration)
                    .WithMany(p => p.SYS_PlanDurations)
                    .HasForeignKey(d => d.DurationId)
                    .HasConstraintName("FK_SYS_Plans_SYS_Lookups");

                entity.HasOne(d => d.PlanType)
                    .WithMany(p => p.SYS_PlanPlanTypes)
                    .HasForeignKey(d => d.PlanTypeId)
                    .HasConstraintName("FK_SYS_Plans_SYS_Lookups1");
            });

            modelBuilder.Entity<SYS_PlanSubscription>(entity =>
            {
                entity.HasKey(e => e.UserSubscriptionId)
                    .HasName("PK__SYS_Plan__3A675EF86B682FCC");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsCancalled).HasDefaultValueSql("((0))");

                entity.Property(e => e.StripeCustomerId).HasMaxLength(250);

                entity.Property(e => e.StripeSubscriptionId).HasMaxLength(250);

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.SYS_PlanSubscriptions)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanSubscriptionsPlanId_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SYS_PlanSubscriptions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanSubscriptions_UserId");
            });

            modelBuilder.Entity<SYS_Role>(entity =>
            {
                entity.HasKey(e => e.SubRoleId)
                    .HasName("PK_Roles");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SubRole).HasMaxLength(50);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.SYS_Roles)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_Roles_SYS_Users");

                entity.HasOne(d => d.ParentRole)
                    .WithMany(p => p.SYS_Roles)
                    .HasForeignKey(d => d.ParentRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_Roles_SYS_Lookups");
            });

            modelBuilder.Entity<SYS_Speciality>(entity =>
            {
                entity.HasKey(e => e.SpecialityId)
                    .HasName("PK__SYS_Spec__67ED609B204CE827");

                entity.Property(e => e.Value).HasMaxLength(250);
            });

            modelBuilder.Entity<SYS_Staff>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.Property(e => e.StaffId).ValueGeneratedNever();

                entity.Property(e => e.JoiningDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SocialSecurityNumber).HasMaxLength(250);

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.SYS_Staffs)
                    .HasForeignKey(d => d.CurrencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_Staffs_SYS_Lookups");

                entity.HasOne(d => d.Staff)
                    .WithOne(p => p.SYS_Staff)
                    .HasForeignKey<SYS_Staff>(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_Staffs_SYS_Users");

                entity.HasOne(d => d.SubRole)
                    .WithMany(p => p.SYS_Staffs)
                    .HasForeignKey(d => d.SubRoleId)
                    .HasConstraintName("FK_SYS_Staffs_SYS_Roles");
            });

            modelBuilder.Entity<SYS_State>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK__SYS_Stat__C3BA3B3A7A7A6F36");

                entity.Property(e => e.StateId).ValueGeneratedNever();

                entity.Property(e => e.Value).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SYS_States)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountriesStates_CountryId");
            });

            modelBuilder.Entity<SYS_SubSpeciality>(entity =>
            {
                entity.HasKey(e => e.SubSpecialityId)
                    .HasName("PK__SYS_SubS__A21E171A0A63662E");

                entity.Property(e => e.Value).HasMaxLength(250);
            });

            modelBuilder.Entity<SYS_User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__SYS_User__1788CC4C03228557");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ProfilePicture).HasMaxLength(1000);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.SYS_Users)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_SYS_Users_SYS_Cities");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SYS_Users)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_SYS_Users_SYS_Countries");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.SYS_UserGenders)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_SYS_Users_SYS_Lookups1");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.SYS_UserMaritalStatuses)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_SYS_Users_SYS_Lookups2");

                entity.HasOne(d => d.OTPMedium)
                    .WithMany(p => p.SYS_UserOTPMedia)
                    .HasForeignKey(d => d.OTPMediumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_Users_SYS_Lookups");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SYS_UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_Users_SYS_Lookups3");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.SYS_Users)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_SYS_Users_SYS_States");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.SYS_UserTitles)
                    .HasForeignKey(d => d.TitleId)
                    .HasConstraintName("FK_SYS_Users_SYS_Lookups4");
            });

            modelBuilder.Entity<SYS_UserLang>(entity =>
            {
                entity.HasKey(e => e.UserLanguageId);

                entity.ToTable("SYS_UserLang");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SYS_UserLangs)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_SYS_UserLang_SYS_UserLang");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SYS_UserLangs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SYS_UserLang_SYS_Users");
            });

            modelBuilder.Entity<SYS_UserLanguage>(entity =>
            {
                entity.HasKey(e => e.UserLanguageId);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SYS_UserLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_UserLanguages_SYS_UserLanguages");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SYS_UserLanguages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_UserLanguages_SYS_Users");
            });

            modelBuilder.Entity<SecureChat>(entity =>
            {
                entity.ToTable("SecureChat");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.SecureChats)
                    .HasForeignKey(d => d.FromUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecureChat_SYS_Users");
            });

            modelBuilder.Entity<Staff_Schedule>(entity =>
            {
                entity.HasKey(e => e.StaffDayId);

                entity.Property(e => e.EndTime).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasMaxLength(50);

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Staff_Schedules)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staff_Schedules_SYS_Lookups");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Staff_Schedules)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staff_Schedules_SYS_Staffs");
            });

            modelBuilder.Entity<Sys_PushNotification>(entity =>
            {
                entity.HasKey(e => e.PushNotificationId);

                entity.ToTable("Sys_PushNotification");

                entity.Property(e => e.DeviceId).HasMaxLength(500);

                entity.HasOne(d => d.DeviceType)
                    .WithMany(p => p.Sys_PushNotifications)
                    .HasForeignKey(d => d.DeviceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sys_PushNotification_SYS_Lookups");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Sys_PushNotifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sys_PushNotification_SYS_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
