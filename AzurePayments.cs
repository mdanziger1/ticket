using System.Data.Entity;

namespace UTA.API.DAL.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AzurePayments : DbContext
    {
        public AzurePayments()
            : base("name=AzurePayments")
        {
        }

        public AzurePayments(string connString)
            : base(connString)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<InvoiceItemCode> InvoiceItemCodes { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<PaymentLog> PaymentLogs { get; set; }

        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<DocumentUpload> DocumentUploads { get; set; }
        public virtual DbSet<RegistrationRequirement> RegistrationRequirements { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }
        public virtual DbSet<view_TransactionTotals> view_TransactionTotals { get; set; }
        public virtual DbSet<view_TransactionTotalsAll> view_TransactionTotalsAll { get; set; }

        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<ContactUsFormSetting> ContactUsFormSettings { get; set; }
        public virtual DbSet<Strings> Strings { get; set; }
        public virtual DbSet<AccountDocument> AccountDocuments { get; set; }
        public virtual DbSet<Rewards> Rewards { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<view_PaymentsALL> view_PaymentsALL { get; set; }
        public virtual DbSet<view_PaymentsAndSchedules> view_PaymentsAndSchedules { get; set; }
        public virtual DbSet<view_TransactionDetails> view_TransactionDetails { get; set; }
        public virtual DbSet<view_TransactionDetailsAll> view_TransactionDetailsAll { get; set; }
        public virtual DbSet<view_LoginsLog> view_LoginsLog { get; set; }
        public virtual DbSet<ScheduledTransectionDetailCategory> ScheduledTransectionDetailCategories { get; set; }
        public virtual DbSet<ScheduledTransectionDetails> ScheduledTransectionDetails { get; set; }
        public virtual DbSet<ScheduledTransection> ScheduledTransections { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<SMS> SMS { get; set; }
        public virtual DbSet<SMS_Queue> SMS_Queue { get; set; }
        public virtual DbSet<view_AccountAccess> view_AccountAccess { get; set; }
        public virtual DbSet<view_AccontInfo> view_AccontInfo { get; set; }
        public virtual DbSet<IVRCallDetail> IVRCallDetails { get; set; }
        public virtual DbSet<IVRCall> IVRCalls { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<HDate> HDates { get; set; }
        public virtual DbSet<DayCampSetup> DayCampSetup { get; set; }
        public virtual DbSet<GradesSetup> GradesSetup { get; set; }
        public virtual DbSet<DayCampEnrollments> DayCampEnrollments { get; set; }
        public virtual DbSet<view_TrasnportationBalance> view_TrasnportationBalance { get; set; }
        public virtual DbSet<PrintCard> PrintedCards { get; set; }
        public virtual DbSet<view_TuitionBalanceDC> view_TuitionBalanceDC { get; set; }
        public virtual DbSet<ClassSetup> ClassSetups { get; set; }
        public virtual DbSet<SMLookup> SMLookups { get; set; }
        public virtual DbSet<view_LapidusAccounts> view_LapidusAccounts { get; set; }
        public virtual DbSet<LapidusCountryInfo> LapidusCountryInfos { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
        public virtual DbSet<view_LapidusStudents> view_LapidusStudents { get; set; }
        public virtual DbSet<view_LapidusPayments> view_LapidusPayments { get; set; }
        public virtual DbSet<AdminPortalCoulmnConfig> AdminPortalCoulmnConfigs { get; set; }
        public virtual DbSet<view_AdminPortalRoles> view_AdminPortalRoles { get; set; }
        public virtual DbSet<Immunization> Immunizations { get; set; }
        public virtual DbSet<ImmunizationDetail> ImmDetails { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<view_IVRCalls> view_IVRCalls { get; set; }
        public virtual DbSet<PendingDocument> PendingDocuments { get; set; }
        public virtual DbSet<view_PaymentLog> view_PaymentLog { get; set; }
        public virtual DbSet<view_ScheduleDetails> view_ScheduleDetails { get; set; }
        public virtual DbSet<view_Schedules> view_Schedules { get; set; }
        public virtual DbSet<view_DocumentUploads> view_DocumentUploads { get; set; }
        public virtual DbSet<view_SMS> view_SMS { get; set; }
        public virtual DbSet<AccountSettingList> AccountSettingList { get; set; }
        public virtual DbSet<AccountSetting> AccountSettings { get; set; }
        public virtual DbSet<view_CoronaInfo> view_CoronaInfo { get; set; }
        public virtual DbSet<CoronaInfo> CoronaInfoes { get; set; }
        public virtual DbSet<CoronaRecording> CoronaRecordings { get; set; }
        public virtual DbSet<Xtemp> Xtemps { get; set; }
        public virtual DbSet<CoronaStudentMessage> CoronaStudentMessages { get; set; }
        public virtual DbSet<CoronaTeacherNumber> CoronaTeacherNumbers { get; set; }
        public virtual DbSet<CoronaCDRAlertSetting> CoronaCDRAlertSettings { get; set; }
        public virtual DbSet<CoronaHotlineNumber> CoronaHotlineNumbers { get; set; }
        public virtual DbSet<CoronaStudentTestAnswer> CoronaStudentTestAnswers { get; set; }
        public virtual DbSet<CoronaStudentTestAnswerSetup> CoronaStudentTestAnswerSetups { get; set; }
        public virtual DbSet<CoronaStudentTestQuestion> CoronaStudentTestQuestions { get; set; }
        public virtual DbSet<CoronaStudentTestSetup> CoronaStudentTestSetups { get; set; }
        public virtual DbSet<CoronaStudentPoint> CoronaStudentPoints { get; set; }
        public virtual DbSet<CoronaPhoneLineSetting> CoronaPhoneLineSettings { get; set; }
        public virtual DbSet<view_CoronaStudentPoints> view_CoronaStudentPoints { get; set; }
        public virtual DbSet<CoronaStudentInfo> CoronaStudentInfo { get; set; }
        public virtual DbSet<CoronaClassInfo> CoronaClassInfo { get; set; }
        public virtual DbSet<view_CoronaStudentPointsDetails> view_CoronaStudentPointsDetails { get; set; }
        public virtual DbSet<CoronaMultipleClassesLog> CoronaMultipleClassesLogs { get; set; }
        public virtual DbSet<CoronaMultipleClassesLogDetail> CoronaMultipleClassesLogDetails { get; set; }
        public virtual DbSet<CoronaMultipleClassesSetup> CoronaMultipleClassesSetups { get; set; }
        public virtual DbSet<LadiesAuxiliaryProgramAnswer> LadiesAuxiliaryProgramAnswers { get; set; }
        public virtual DbSet<CountryCensu> CountryCensus { get; set; }
        public virtual DbSet<LapidusTermSetting> LapidusTermSettings { get; set; }
        public virtual DbSet<GirlsCampCharge> GirlsCampCharges { get; set; }
        public virtual DbSet<view_GirlsCampAccounts> view_GirlsCampAccounts { get; set; }
        public virtual DbSet<view_GirlsCampCards> view_GirlsCampCards { get; set; }
        public virtual DbSet<view_GirlsCampPayments> view_GirlsCampPayments { get; set; }
        public virtual DbSet<view_GirlsCampStudents> view_GirlsCampStudents { get; set; }
        public virtual DbSet<GirlsCampCovidTestLable> GirlsCampCovidTestLables { get; set; }
        public virtual DbSet<view_GirlsCampCovidTestLabels> view_GirlsCampCovidTestLables { get; set; }
        public virtual DbSet<view_DayCampEnrollmentStatus> view_DayCampEnrollmentStatus { get; set; }
        public virtual DbSet<CovidScreening> CovidScreenings { get; set; }
        public virtual DbSet<GirlsCampAccountInfo> GirlsCampAccountInfoes { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<CovidScreeningSmsMessage> CovidScreeningSmsMessages { get; set; }
        public virtual DbSet<CovidScreeningSmsSession> CovidScreeningSmsSessions { get; set; }
        public virtual DbSet<CovidScreeningSmsDetail> CovidScreeningSmsDetails { get; set; }
        public virtual DbSet<view_CovidScreening> view_CovidScreening { get; set; }
        public virtual DbSet<CovidScreeningPhoneLog> CovidScreeningPhoneLogs { get; set; }
        public virtual DbSet<view_CovidScreeningSessions> view_CovidScreeningSessions { get; set; }
        public virtual DbSet<view_CovidScreeningStatus> view_CovidScreeningStatus { get; set; }
        public virtual DbSet<Communication> Communications { get; set; }
        public virtual DbSet<CallbackRequest> CallbackRequests { get; set; }
        public virtual DbSet<view_Communications> view_Communications { get; set; }
        public virtual DbSet<view_SmsPendingMessages> view_SmsPendingMessages { get; set; }
        public virtual DbSet<VMForm> VMForms { get; set; }
        public virtual DbSet<VMformsLog> VMformsLogs { get; set; }
        public virtual DbSet<KollelForm> KollelForms { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<view_StudentsToScreen> view_StudentsToScreen { get; set; }
        public virtual DbSet<Call> Calls { get; set; }
        public virtual DbSet<view_Students> view_Students { get; set; }
        public virtual DbSet<view_StudentsAll> view_StudentsAll { get; set; }
        public virtual DbSet<view_Donations> view_Donations { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<CustomerEmail> CustomerEmails { get; set; }
        public virtual DbSet<view_CustomerEmails> view_CustomerEmails { get; set; }
        public virtual DbSet<FoodDistributionInfo> FoodDistributionInfo { get; set; }
        public virtual DbSet<FoodDistributionSiblings> FoodDistributionSiblings { get; set; }
        public virtual DbSet<view_FoodDistributionInfo> view_FoodDistributionInfo { get; set; }
        public virtual DbSet<CovidTest> CovidTests { get; set; }
        public virtual DbSet<view_Calls> view_Calls { get; set; }
        public virtual DbSet<view_FoodDistributionAccountInfo> view_FoodDistributionAccountInfo { get; set; }
        public virtual DbSet<FoodDistribtionBox> FoodDistribtionBoxes { get; set; }
        public virtual DbSet<FoodDistributionScan> FoodDistributionScans { get; set; }
        public virtual DbSet<FoodWeeklyDistribution> FoodWeeklyDistributions { get; set; }
        public virtual DbSet<view_FoodDistributionBoxes> view_FoodDistributionBoxes { get; set; }
        public virtual DbSet<view_FoodDistributionRoutes> view_FoodDistributionRoutes { get; set; }
        public virtual DbSet<view_FoodDistributionFeedback> view_FoodDistributionFeedback { get; set; }
        public virtual DbSet<view_FoodDistributionScanInfo> view_FoodDistributionScanInfo { get; set; }
        public virtual DbSet<FoodDistributionFeedback> FoodDistributionFeedbacks { get; set; }
        public virtual DbSet<view_FoodDistributionEnrollmentChanges> view_FoodDistributionEnrollmentChanges { get; set; }
        public virtual DbSet<PlivoCallInstruction> PlivoCallInstructions { get; set; }
        public virtual DbSet<view_FoodDistributionSiblings> view_FoodDistributionSiblings { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<FoodDistributionCoupon> FoodDistributionCoupons { get; set; }
        public virtual DbSet<view_FoodDistributionBoxIncreases> view_FoodDistributionBoxIncreases { get; set; }
        public virtual DbSet<FoodDistributionNotificationSetting> FoodDistributionNotificationSettings { get; set; }
        public virtual DbSet<FoodDistributionMenuItem> FoodDistributionMenuItems { get; set; }
        public virtual DbSet<FoodDistributionLog> FoodDistributionLogs { get; set; }
        public virtual DbSet<AudioLibrary> AudioLibraries { get; set; }
        public virtual DbSet<view_CallsReport> view_CallsReport { get; set; }
        public virtual DbSet<Broadcast> Broadcasts { get; set; }
        public virtual DbSet<view_Surveys> view_Surveys { get; set; }
        public virtual DbSet<PendingCall> PendingCalls { get; set; }
        public virtual DbSet<view_Broadcasts> view_Broadcasts { get; set; }
        public virtual DbSet<view_FoodDistributionLogs> view_FoodDistributionLogs { get; set; }
        public virtual DbSet<BroadcastDraftNumber> BroadcastDraftNumbers { get; set; }
        public virtual DbSet<view_BroadcastDrafts> view_BroadcastDrafts { get; set; }
        public virtual DbSet<LapidusTransaction> LapidusTransactions { get; set; }
        public virtual DbSet<view_LapidusTransactions> view_LapidusTransactions { get; set; }
        public virtual DbSet<CampBroadcast> CampBroadcasts { get; set; }
        public virtual DbSet<CampCallRecording> CampCallRecordings { get; set; }
        public virtual DbSet<CampCall> CampCalls { get; set; }
        public virtual DbSet<CampIVRDetail> CampIVRDetails { get; set; }        
        public virtual DbSet<CampStaff> CampStaffs { get; set; }
        public virtual DbSet<CampStudentPhoneFilter> CampStudentPhoneFilters { get; set; }
        public virtual DbSet<CampStudentSetting> CampStudentSettings { get; set; }
        public virtual DbSet<CampVoicemail> CampVoicemails { get; set; }
        public virtual DbSet<view_CampStudents> view_CampStudents { get; set; }
        public virtual DbSet<view_CampCalls> view_CampCalls { get; set; }
        public virtual DbSet<CampBlockList> CampBlockLists { get; set; }
        public virtual DbSet<CampPhoneSchedule> CampPhoneSchedules { get; set; }
        public virtual DbSet<SignalwireCall> SignalwireCalls { get; set; }
        public virtual DbSet<CampCallRecordingRequest> CampCallRecordingRequests { get; set; }
        public virtual DbSet<RewardsPlus> RewardsPlus { get; set; }
        public virtual DbSet<view_TuitionBalanceSupper> view_TuitionBalanceSupper { get; set; }
        public virtual DbSet<RewardsPlusTempPin> RewardsPlusTempPins { get; set; }
        public virtual DbSet<view_KollelForms> view_KollelForms { get; set; }
        public virtual DbSet<Kiosk> Kiosks { get; set; }
        public virtual DbSet<KioskSetting> KioskSettings { get; set; }
        public virtual DbSet<KioskLog> KioskLogs { get; set; }
        public virtual DbSet<KollelScannedApplication> KollelScannedApplications { get; set; }
        public virtual DbSet<KollelFormLog> KollelFormLogs { get; set; }
        public virtual DbSet<NewStudent> NewStudents { get; set; }
        public virtual DbSet<view_KollelFormLogs> view_KollelFormLogs { get; set; }
        public virtual DbSet<view_StudentCalls> view_StudentCalls { get; set; }
        public virtual DbSet<SchoolIvrDetail> SchoolIvrDetails { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<view_Branches> view_Branches { get; set; }
        public virtual DbSet<ClassesGSF> ClassesGSFs { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<view_Students_ClassInfo> view_Students_ClassInfo { get; set; }
        public virtual DbSet<view_Students_RegistrationClassInfo> view_Students_RegistrationClassInfo { get; set; }        
        public virtual DbSet<view_Students_RegistrationClassInfoExtended> view_Students_RegistrationClassInfoExtended { get; set; }        
        public virtual DbSet<view_ClassInfo> view_ClassInfo { get; set; }
        public virtual DbSet<view_QueueReport> view_QueueReport { get; set; }
        public virtual DbSet<KitaAlefMessage> KitaAlefMessages { get; set; }
        public virtual DbSet<HighSchoolAbsentSunday> HighSchoolAbsentSundays { get; set; }
        public virtual DbSet<StudentPin> StudentPins { get; set; }
        public virtual DbSet<SpecialNeedsProgram> SpatialNeedsPrograms { get; set; }
        public virtual DbSet<SpecialNeedsProgramAction> SpecialNeedsProgramActions { get; set; }
        public virtual DbSet<SpecialNeedsProgramDocument> SpecialNeedsProgramDocuments { get; set; }
        public virtual DbSet<view_SpecialNeedsProgram> view_SpecialNeedsProgram { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<view_Feedback> view_Feedback { get; set; }
        public virtual DbSet<FeedbackEmail> FeedbackEmails { get; set; }
        public virtual DbSet<SpecialNeedsProgramProgressReport> SpecialNeedsProgramProgressReports { get; set; }
        public virtual DbSet<SchoolPhone> SchoolPhones { get; set; }
        public virtual DbSet<TeacherSetting> TeacherSettings { get; set; }
        public virtual DbSet<view_Teachers> view_Teachers { get; set; }
        public virtual DbSet<BranchPhone> BranchPhones { get; set; }
        public virtual DbSet<SchoolCall> SchoolCalls { get; set; }
        public virtual DbSet<Tip> Tips { get; set; }
        public virtual DbSet<view_Donors> view_Donors { get; set; }
        public virtual DbSet<DonorSetting> DonorSettings { get; set; }
        public virtual DbSet<view_Tips> view_Tips { get; set; }
        public virtual DbSet<TipEntry> TipEntries { get; set; }
        public virtual DbSet<PaymentPickup> PaymentPickups { get; set; }
        public virtual DbSet<view_PaymentPickups> view_PaymentPickups { get; set; }
        public virtual DbSet<Messenger> Messengers { get; set; }
        public virtual DbSet<view_SchoolPhones> view_SchoolPhones { get; set; }
        public virtual DbSet<view_SchoolCalls> view_SchoolCalls { get; set; }
        public virtual DbSet<SchoolExternalCall> SchoolExternalCalls { get; set; }
        public virtual DbSet<UnidentifiedNumber> UnidentifiedNumbers { get; set; }
        public virtual DbSet<SchoolPhoneAllowList> SchoolPhoneAllowLists { get; set; }
        public virtual DbSet<view_NotAssignedStudents> view_NotAssignedStudents { get; set; }
        public virtual DbSet<view_AllPhones> view_AllPhones { get; set; }
        public virtual DbSet<view_Transactions> view_Transactions { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<FundSetting> FundSettings { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<view_Appointments> view_Appointments { get; set; }
        public virtual DbSet<TipsIvrTeacher> TipsIvrTeachers { get; set; }
        public virtual DbSet<BroadcastNumber> BroadcastNumbers { get; set; }
        public virtual DbSet<view_BroadcastCalls> view_BroadcastCalls { get; set; }
        public virtual DbSet<view_BroadcastMessages> view_BroadcastMessages { get; set; }
        public virtual DbSet<TeacherRelation> TeacherRelations { get; set; }
        public virtual DbSet<view_TipTransactions> view_TipTransactions { get; set; }
        public virtual DbSet<StudentsTherapyInfo> StudentsTherapyInfoes { get; set; }
        public virtual DbSet<SummerTermSetting> SummerTermSettings { get; set; }
        public virtual DbSet<SummerCharge> SummerCharges { get; set; }
        public virtual DbSet<view_YKCAccountsBasic> view_YKCAccountsBasics { get; set; }
        public virtual DbSet<view_YKCAccounts> view_YKCAccounts { get; set; }
        public virtual DbSet<view_YKCPayments> view_YKCPayments { get; set; }
        public virtual DbSet<view_YKCStudents> view_YKCStudents { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<view_YKCDocuments> view_YKCDocuments { get; set; }
        public virtual DbSet<RecentPage> RecentPages { get; set; }
        public virtual DbSet<CheckDetail> CheckDetails { get; set; }
        public virtual DbSet<view_YKCPaymentDetails> view_YKCPaymentDetails { get; set; }
        public virtual DbSet<view_LapidusDayCampAccounts> view_LapidusDayCampAccounts { get; set; }
        public virtual DbSet<view_YKCUnprocessedPayments> view_YKCUnprocessedPayments { get; set; }
        public virtual DbSet<view_YKCNotes> view_YKCNotes { get; set; }
        public virtual DbSet<view_CampCallLogs> view_CampCallLogs { get; set; }
        public virtual DbSet<CampDistributionChange> CampDistributionChanges { get; set; }
        public virtual DbSet<CampDistribution> CampDistributions { get; set; }
        public virtual DbSet<CampFamily> CampFamilies { get; set; }
        public virtual DbSet<CampInfo> CampInfoes { get; set; }
        public virtual DbSet<CampMenuItemChoice> CampMenuItemChoices { get; set; }
        public virtual DbSet<CampMenuItem> CampMenuItems { get; set; }
        public virtual DbSet<CampDistributionCall> CampDistributionCalls { get; set; }
        public virtual DbSet<CampFoodDistributionRequest> CampFoodDistributionRequests { get; set; }
        public virtual DbSet<CampDistributionLog> CampDistributionLogs { get; set; }
        public virtual DbSet<view_CampFoodDistributionRequests> view_CampFoodDistributionRequests { get; set; }
        public virtual DbSet<view_CampFoodDistributionLogs> view_CampFoodDistributionLogs { get; set; }
        public virtual DbSet<view_CampFamilies> view_CampFamilies { get; set; }
        public virtual DbSet<view_CampDistributionIVRCalls> view_CampDistributionIVRCalls { get; set; }
        public virtual DbSet<FileDownload> FileDownloads { get; set; }
        public virtual DbSet<view_LapidusUnprocessedPayments> view_LapidusUnprocessedPayments { get; set; }
        public virtual DbSet<view_VMFormLogs> view_VMFormLogs { get; set; }
        public virtual DbSet<view_StudentsNewYear> view_StudentsNewYear { get; set; }
        public virtual DbSet<BlockedAppointmentDate> BlockedAppointmentDates { get; set; }
        public virtual DbSet<view_KapuresTotal> view_KapuresTotal { get; set; }
        public virtual DbSet<view_Kapures> view_Kapures { get; set; }
        public virtual DbSet<view_TipPayments> view_TipPayments { get; set; }
        public virtual DbSet<YKStudent> YKStudents { get; set; }
        public virtual DbSet<YKValuesRecording> YKValuesRecordings { get; set; }
        public virtual DbSet<TipRecording> TipRecordings { get; set; }
        public virtual DbSet<SchoolPhoneSchedule> SchoolPhoneSchedules { get; set; }
        public virtual DbSet<NewAccountApplication> NewAccountApplications { get; set; }
        public virtual DbSet<view_NewFamilyApplications> view_NewFamilyApplications { get; set; }
        public virtual DbSet<ClassTeacher> ClassTeachers { get; set; }
        public virtual DbSet<view_TeachersAllPositions> view_TeachersAllPositions { get; set; }
        public virtual DbSet<TeacherNotification> TeacherNotifications { get; set; }
        public virtual DbSet<view_TeacherRelations> view_TeacherRelations { get; set; }
        public virtual DbSet<view_Students_AttendanceCards> view_Students_AttendanceCards { get; set; }
        public virtual DbSet<StudentIdCard> StudentIdCards { get; set; }
        public virtual DbSet<view_Students_AttendanceScans> view_Students_AttendanceScans { get; set; }
        public virtual DbSet<view_ImmunizationsByStudent> view_ImmunizationsByStudent { get; set; }
        public virtual DbSet<view_EBTData> view_EBTData { get; set; }
        public virtual DbSet<view_BroadcastEmails> view_BroadcastEmails { get; set; }
        public virtual DbSet<DOE> DOEs { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<view_MasterList> view_MasterList { get; set; }
        public virtual DbSet<view_Matches> view_Matches { get; set; }
        public virtual DbSet<view_DOE> view_DOE { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<view_VMAccountStatus> view_VMAccountStatus { get; set; }
        public virtual DbSet<YgStudent> YgStudents { get; set; }
        public virtual DbSet<EmailSetting> EmailSettings { get; set; }
        public virtual DbSet<ImmunizationBroadcastSetting> ImmunizationBroadcastSettings { get; set; }
        public virtual DbSet<view_TeachersHighSchool> view_TeachersHighSchool { get; set; }
        public virtual DbSet<GradeTerm> GradeTerms { get; set; }
        public virtual DbSet<LapidusBilling> LapidusBillings { get; set; }
        public virtual DbSet<view_LapidusBilling> view_LapidusBilling { get; set; }
        public virtual DbSet<CategoryPaymentType> CategoryPaymentTypes { get; set; }
        public virtual DbSet<view_NewStudents> view_NewStudents { get; set; }
        public virtual DbSet<HsStudent> HsStudents { get; set; }
        public virtual DbSet<view_HsStudents> view_HsStudents { get; set; }
        public virtual DbSet<view_Search> view_Search { get; set; }
        public virtual DbSet<AdminPortalLogin> AdminPortalLogins { get; set; }
        public virtual DbSet<view_LapidusDocuments> view_LapidusDocuments { get; set; }
        public virtual DbSet<view_VotingRegNotes> view_VotingRegNotes { get; set; }
        public virtual DbSet<view_CampDistributionDefaultTotals> view_CampDistributionDefaultTotals { get; set; }
        public virtual DbSet<AutoMatchDetail> AutoMatchDetails { get; set; }
        public virtual DbSet<AutoMatch> AutoMatches { get; set; }
        public virtual DbSet<view_AutoMatchDetails> view_AutoMatchDetails { get; set; }
        public virtual DbSet<view_AutoMatches> view_AutoMatches { get; set; }
        public virtual DbSet<view_StudentAutoMatchDetails> view_StudentAutoMatchDetails { get; set; }
        public virtual DbSet<view_VmFormsExtended> view_VmFormsExtended { get; set; }
        public virtual DbSet<AdminPortalNavigationSetting> AdminPortalNavigationSettings { get; set; }
        public virtual DbSet<PendingBusChange> PendingBusChanges { get; set; }
        public virtual DbSet<Bus> Bus { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<CholHamoedProgramReport> CholHamoedProgramReports { get; set; }
        public virtual DbSet<CholHamoedProgramSetting> CholHamoedProgramSettings { get; set; }
        public virtual DbSet<view_CholHamoedProgramReports> view_CholHamoedProgramReports { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<AttendanceScan> AttendanceScans { get; set; }
        public virtual DbSet<view_ButcherRewards> view_ButcherRewards { get; set; }
        public virtual DbSet<view_YgStudentsList> view_YgStudentsList { get; set; }
        public virtual DbSet<KesherCustomRelation> KesherCustomRelations { get; set; }
        public virtual DbSet<KesherEmployeePosition> KesherEmployeePositions { get; set; }
        public virtual DbSet<KesherEmployee> KesherEmployees { get; set; }
        public virtual DbSet<KesherEmployeeTeacherCode> KesherEmployeeTeacherCodes { get; set; }
        public virtual DbSet<KesherParentBalanceTransaction> KesherParentBalanceTransactions { get; set; }
        public virtual DbSet<KesherPositionType> KesherPositionTypes { get; set; }
        public virtual DbSet<KesherTip> KesherTips { get; set; }
        public virtual DbSet<view_KesherEmployees> view_KesherEmployees { get; set; }
        public virtual DbSet<EmployeeList> EmployeeList { get; set; }
        public virtual DbSet<view_TipTransactionsNew> view_TipTransactionsNew { get; set; }
        public virtual DbSet<view_KesherTip> view_KesherTips { get; set; }
        public virtual DbSet<KesherTipAcknowledgment> KesherTipAcknowledgments { get; set; }
        public virtual DbSet<KesherStatement> KesherStatements { get; set; }
        public virtual DbSet<BroadcastContact> BroadcastContacts { get; set; }
        public virtual DbSet<VoterAccountSetting> VoterAccountSettings { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<view_UnprocessedPayments> view_UnprocessedPayments { get; set; }
        public virtual DbSet<Buses> Buses { get; set; }
        public virtual DbSet<Driver_Bus> Driver_Bus { get; set; }
        public virtual DbSet<DriverAbsent> DriverAbsents { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<RouteSchedule> RouteSchedules { get; set; }
        public virtual DbSet<view_Buses> view_Buses { get; set; }
        public virtual DbSet<view_Drivers> view_Drivers { get; set; }
        public virtual DbSet<TempTransportationRoute> TempTransportationRoutes { get; set; }
        public virtual DbSet<view_Driver_Bus> view_Driver_Bus { get; set; }
        public virtual DbSet<view_YearBookAdDonations> view_YearBookAdDonations { get; set; }
        public virtual DbSet<view_Routes> view_Routes { get; set; }
        public virtual DbSet<view_DriverAbsent> view_DriverAbsent { get; set; }
        public virtual DbSet<view_CholHamoedProgramStudents> view_CholHamoedProgramStudents { get; set; }
        public virtual DbSet<TempLapidusBilling2024> TempLapidusBilling2024 { get; set; }
        public virtual DbSet<VotingRegstrationFormStatus> VotingRegstrationFormStatuses { get; set; }
        public virtual DbSet<view_VotingRegstrationFormStatus> view_VotingRegstrationFormStatus { get; set; }
        public virtual DbSet<AdditionalNoteField> AdditionalNoteFields { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<ManageengineRequest> ManageengineRequests { get; set; }
        public virtual DbSet<ManageengineConversation> ManageengineConversations { get; set; }
        public virtual DbSet<ManageengineUser> ManageengineUsers { get; set; }
        public virtual DbSet<view_ManageengineRequests> view_ManageengineRequests { get; set; }
        public virtual DbSet<C12GForms> C12GForms { get; set; }
        public virtual DbSet<view_FormCards> view_FormCards { get; set; }
        public virtual DbSet<TuitionDiscountRequest> TuitionDiscountRequests { get; set; }
        public virtual DbSet<view_TuitionDiscountRequests> view_TuitionDiscountRequests { get; set; }
        public virtual DbSet<view_AdminPortalUsers> view_AdminPortalUsers { get; set; }
        public virtual DbSet<CreditCardChargeAttachment> CreditCardChargeAttachments { get; set; }
        public virtual DbSet<CreditCardCharge> CreditCardCharges { get; set; }
        public virtual DbSet<CreditCardUser> CreditCardUsers { get; set; }
        public virtual DbSet<view_CreditCardCharges> view_CreditCardCharges { get; set; }
        public virtual DbSet<DriverAbsentReportReason> DriverAbsentReportReasons { get; set; }
        public virtual DbSet<SharedFile> SharedFiles { get; set; }
        public virtual DbSet<SharedFileUser> SharedFileUsers { get; set; }
        public virtual DbSet<view_SharedFiles> view_SharedFiles { get; set; }
        public virtual DbSet<SchoolSource> SchoolSources { get; set; }
        public virtual DbSet<BlockedFileType> BlockedFileTypes { get; set; }
        public virtual DbSet<view_ApplicantStudents> view_ApplicantStudents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.PinNum)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccountLinkID)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.ClientIP)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.Method)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.NameID)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.CardNum)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.ExpDate)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.CVV)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.ResultCode)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.TransactionCode)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.AuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.AVSResults)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.TransactionResult)
                .IsUnicode(false);

            //modelBuilder.Entity<PaymentLog>()
            //    .Property(e => e.ReverseReason)
            //    .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.PhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.ReceiptNum)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.Host)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .Property(e => e.SourceKey)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentLog>()
                .HasMany(e => e.PaymentLog1)
                .WithOptional(e => e.PaymentLog2)
                .HasForeignKey(e => e.ParentPaymentID);

            modelBuilder.Entity<DocumentType>()
                .Property(e => e.DocTypeID)
                .IsFixedLength();

            modelBuilder.Entity<DocumentType>()
                .Property(e => e.FormName)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentUpload>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<DocumentUpload>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<DocumentUpload>()
                .Property(e => e.DocTypeID)
                .IsFixedLength();

            modelBuilder.Entity<DocumentUpload>()
                .Property(e => e.FileURL)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentUpload>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationRequirement>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<RegistrationRequirement>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<RegistrationRequirement>()
                .Property(e => e.DocTypeID)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.TxnType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.UserUpdated)
                .IsUnicode(false);

            modelBuilder.Entity<view_TransactionTotals>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_TransactionTotals>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_TransactionTotalsAll>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_TransactionTotalsAll>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LoginsLog>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_LoginsLog>()
                .Property(e => e.ClientIP)
                .IsUnicode(false);

            modelBuilder.Entity<view_LoginsLog>()
                .Property(e => e.Referer)
                .IsUnicode(false);

            modelBuilder.Entity<ContactUs>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<ContactUs>()
                .Property(e => e.Call_Uuid)
                .IsUnicode(false);

            modelBuilder.Entity<Rewards>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<Rewards>()
                .Property(e => e.TxnType)
                .IsUnicode(false);

            modelBuilder.Entity<Rewards>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Rewards>()
                .Property(e => e.RedeemType)
                .IsUnicode(false);

            modelBuilder.Entity<Rewards>()
                .Property(e => e.AddedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.SettingsGroup);

            modelBuilder.Entity<view_PaymentsALL>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<view_PaymentsALL>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentsALL>()
                .Property(e => e.cardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentsALL>()
                .Property(e => e.CardNumLast4)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentsALL>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentsALL>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentsALL>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentsALL>()
                .Property(e => e.Source)
                .IsUnicode(false);
            
            modelBuilder.Entity<view_PaymentsAndSchedules>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);
            
            modelBuilder.Entity<view_PaymentsALL>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentsAndSchedules>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentsAndSchedules>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentsAndSchedules>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentsAndSchedules>()
                .Property(e => e.Source)
                .IsUnicode(false);


            modelBuilder.Entity<view_TransactionDetails>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_TransactionDetails>()
                .Property(e => e.TxnType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_TransactionDetails>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_TransactionDetails>()
                .Property(e => e.CalcAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_TransactionDetailsAll>()
                .Property(e => e.TxnType)
                .IsUnicode(false);

            modelBuilder.Entity<view_TransactionDetailsAll>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_TransactionDetailsAll>()
                .Property(e => e.CalcAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_TransactionDetailsAll>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_TransactionDetailsAll>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_TransactionDetailsAll>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransectionDetailCategory>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ScheduledTransectionDetails>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ScheduledTransectionDetails>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.PhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.NameOnCard)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.CardNum)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.ExpDate)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.CVV)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.RecurrenceType)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.ReceiptNum)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
                .Property(e => e.NameID)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTransection>()
               .HasMany(e => e.ScheduledTransectionDetails)
               .WithRequired(e => e.ScheduledTransection)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<ScheduledTransectionDetails>()
               .HasMany(e => e.ScheduledTransectionDetailCategories)
               .WithRequired(e => e.ScheduledTransectionDetail)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Referer)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Department1)
                .IsUnicode(false);

            modelBuilder.Entity<SMS>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<SMS>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<SMS>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<SMS>()
                .Property(e => e.MessageUUID)
                .IsUnicode(false);

            modelBuilder.Entity<SMS>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccountAccess>()
                .Property(e => e.PinNum)
                .IsUnicode(false);

            modelBuilder.Entity<IVRCallDetail>()
                .Property(e => e.Call_Uuid)
                .IsUnicode(false);

            modelBuilder.Entity<IVRCallDetail>()
                .Property(e => e.EventType)
                .IsUnicode(false);

            modelBuilder.Entity<IVRCallDetail>()
                .Property(e => e.InputDigits)
                .IsUnicode(false);

            modelBuilder.Entity<IVRCallDetail>()
                .Property(e => e.Response)
                .IsUnicode(false);

            modelBuilder.Entity<IVRCall>()
                .Property(e => e.Call_Uuid)
                .IsUnicode(false);

            modelBuilder.Entity<IVRCall>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IVRCall>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneNumber>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<PhoneNumber>()
                .Property(e => e.Emails)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneNumber>()
                .Property(e => e.ForwardNumber)
                .IsFixedLength();

            modelBuilder.Entity<PhoneNumber>()
                .Property(e => e.AppDescription)
                .IsUnicode(false);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcregid)
                .IsUnicode(false);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcclass)
                .IsUnicode(false);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udccharge)
                .IsUnicode(false);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcamt1w)
                .HasPrecision(8, 2);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcamt2w)
                .HasPrecision(8, 2);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcamt3w)
                .HasPrecision(8, 2);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcamt4_2w)
                .HasPrecision(8, 2);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcamt5w)
                .HasPrecision(8, 2);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcamt6w)
                .HasPrecision(8, 2);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcamthalf)
                .HasPrecision(8, 2);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcamtf)
                .HasPrecision(8, 2);

            modelBuilder.Entity<DayCampSetup>()
                .Property(e => e.udcamtew)
                .HasPrecision(8, 2);

            modelBuilder.Entity<DayCampEnrollments>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<DayCampEnrollments>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<DayCampEnrollments>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<DayCampEnrollments>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<DayCampEnrollments>()
                .Property(e => e.RegType)
                .IsUnicode(false);

            modelBuilder.Entity<DayCampEnrollments>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DayCampEnrollments>()
                .Property(e => e.updateserial)
                .IsUnicode(false);

            modelBuilder.Entity<DayCampEnrollments>()
                .Property(e => e.Addsource)
                .IsUnicode(false);

            modelBuilder.Entity<DayCampEnrollments>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DayCampEnrollments>()
                .Property(e => e.AddUser)
                .IsUnicode(false);

            modelBuilder.Entity<DayCampEnrollments>()
               .Property(e => e.UserUpdated)
               .IsUnicode(false);

            modelBuilder.Entity<view_TrasnportationBalance>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_TrasnportationBalance>()
                .Property(e => e.Billed)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_TrasnportationBalance>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<PrintCard>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<PrintCard>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<PrintCard>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<PrintCard>()
                .Property(e => e.RegType)
                .IsUnicode(false);

            modelBuilder.Entity<view_TuitionBalanceDC>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_TuitionBalanceDC>()
                .Property(e => e.Billed)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_TuitionBalanceDC>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<ClassSetup>()
                .Property(e => e.RegID)
                .IsFixedLength();

            modelBuilder.Entity<ClassSetup>()
                .Property(e => e.ClassType)
                .IsUnicode(false);

            modelBuilder.Entity<ClassSetup>()
                .Property(e => e.Grade)
                .IsUnicode(false);

            modelBuilder.Entity<ClassSetup>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<ClassSetup>()
                .Property(e => e.Building)
                .IsUnicode(false);

            modelBuilder.Entity<SMLookup>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusCountryInfo>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<LapidusCountryInfo>()
                .Property(e => e.CountryDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ContactInfo>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<ContactInfo>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<ContactInfo>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ContactInfo>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<ContactInfo>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<ContactInfo>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<ContactInfo>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.Father)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.Bungalow)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.RegType)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.TripAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.Gander)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.Weeks)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.LunchMatchType)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.LunchCaseNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusStudents>()
                .Property(e => e.LunchMatchRecord)
                .IsUnicode(false);

            modelBuilder.Entity<AdminPortalCoulmnConfig>()
                .Property(e => e.DataTable)
                .IsUnicode(false);

            modelBuilder.Entity<AdminPortalCoulmnConfig>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<AdminPortalCoulmnConfig>()
                .Property(e => e.Field)
                .IsUnicode(false);

            modelBuilder.Entity<Immunization>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<Immunization>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<Immunization>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<Immunization>()
                .Property(e => e.Grade)
                .IsFixedLength();

            modelBuilder.Entity<ImmunizationDetail>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<ImmunizationDetail>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<ImmunizationDetail>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.ExpirationDate)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.CVV)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.CardNumberLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_IVRCalls>()
                .Property(e => e.call_UUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_IVRCalls>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<PendingDocument>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<PendingDocument>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<PendingDocument>()
                .Property(e => e.DocTypeID)
                .IsFixedLength();

            modelBuilder.Entity<PendingDocument>()
                .Property(e => e.LocalFilePath)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentLog>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_PaymentLog>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentLog>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentLog>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentLog>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentLog>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentLog>()
                .Property(e => e.Refunds)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentLog>()
                .Property(e => e.TransactionResult)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentLog>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ScheduleDetails>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<view_ScheduleDetails>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_ScheduleDetails>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_ScheduleDetails>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_Schedules>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<view_Schedules>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Schedules>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_Schedules>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Schedules>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_Schedules>()
                .Property(e => e.AmountProcessed)
                .HasPrecision(38, 4);

            modelBuilder.Entity<view_Schedules>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_DocumentUploads>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_DocumentUploads>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_DocumentUploads>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_DocumentUploads>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_DocumentUploads>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_DocumentUploads>()
                .Property(e => e.DocTypeID)
                .IsFixedLength();

            modelBuilder.Entity<view_DocumentUploads>()
                .Property(e => e.LocalFilePath)
                .IsUnicode(false);

            modelBuilder.Entity<view_DocumentUploads>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_DocumentUploads>()
                .Property(e => e.StatusInfo)
                .IsUnicode(false);

            modelBuilder.Entity<AccountSettingList>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AccountSettingList>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_CoronaInfo>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_CoronaInfo>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_CoronaInfo>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<view_CoronaInfo>()
                .Property(e => e.Info)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaInfo>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<CoronaInfo>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaInfo>()
                .Property(e => e.Info)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaRecording>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaRecording>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaRecording>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaStudentMessage>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaTeacherNumber>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaTeacherNumber>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaTeacherNumber>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaTeacherNumber>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaCDRAlertSetting>()
                .Property(e => e.SchoolID)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaCDRAlertSetting>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaCDRAlertSetting>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaCDRAlertSetting>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaCDRAlertSetting>()
                .Property(e => e.LastID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CoronaStudentTestAnswer>()
                .Property(e => e.PinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaStudentTestAnswer>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<CoronaStudentTestQuestion>()
                .HasMany(e => e.CoronaStudentTestAnswers)
                .WithRequired(e => e.CoronaStudentTestQuestion)
                .HasForeignKey(e => e.QuestionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoronaStudentTestQuestion>()
                .HasMany(e => e.CoronaStudentTestAnswerSetups)
                .WithRequired(e => e.CoronaStudentTestQuestion)
                .HasForeignKey(e => e.QuestionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoronaStudentTestSetup>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaStudentTestSetup>()
                .HasMany(e => e.CoronaStudentTestQuestions)
                .WithRequired(e => e.CoronaStudentTestSetup)
                .HasForeignKey(e => e.TestID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoronaStudentPoint>()
                .Property(e => e.PinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaPhoneLineSetting>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<view_CoronaStudentPoints>()
                .Property(e => e.PinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_CoronaStudentPointsDetails>()
                .Property(e => e.PinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaMultipleClassesLog>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaMultipleClassesLog>()
                .Property(e => e.OptionNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaMultipleClassesLog>()
                .HasMany(e => e.CoronaMultipleClassesLogDetails)
                .WithRequired(e => e.CoronaMultipleClassesLog)
                .HasForeignKey(e => e.LogID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoronaMultipleClassesLogDetail>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaMultipleClassesSetup>()
                .Property(e => e.PrimaryPhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<CoronaMultipleClassesSetup>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<LadiesAuxiliaryProgramAnswer>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<CountryCensu>()
                .Property(e => e.Selection)
                .IsUnicode(false);

            modelBuilder.Entity<CountryCensu>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusTermSetting>()
                .Property(e => e.Term)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusTermSetting>()
                .Property(e => e.Term)
                .IsUnicode(false);

            modelBuilder.Entity<GirlsCampCharge>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GirlsCampCharge>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<view_GirlsCampAccounts>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_GirlsCampAccounts>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampAccounts>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampAccounts>()
                .Property(e => e.Debit)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_GirlsCampAccounts>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_GirlsCampCards>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_GirlsCampCards>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampCards>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampCards>()
                .Property(e => e.Sename)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampCards>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampCards>()
                .Property(e => e.Sbarcode)
                .IsFixedLength();

            modelBuilder.Entity<view_GirlsCampCards>()
                .Property(e => e.Weeks)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.TxnType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.CalcAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.UserUpdated)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.TransactionResult)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.AuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampPayments>()
                .Property(e => e.SourceKey)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.Father)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.LapidusGrade)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.RegType)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampStudents>()
                .Property(e => e.Weeks)
                .IsUnicode(false);

            modelBuilder.Entity<GirlsCampCovidTestLable>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<GirlsCampCovidTestLable>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<GirlsCampCovidTestLable>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampCovidTestLabels>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_GirlsCampCovidTestLabels>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampCovidTestLabels>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_GirlsCampCovidTestLabels>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreening>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<CovidScreening>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<GirlsCampAccountInfo>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<GirlsCampAccountInfo>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<Note>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Note>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Note>()
                .Property(e => e.TypeID)
                .IsUnicode(false);

            modelBuilder.Entity<Note>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningSmsMessage>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningSmsMessage>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningSmsMessage>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningSmsMessage>()
                .Property(e => e.MessageUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningSmsSession>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningSmsSession>()
                .Property(e => e.MessageUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningSmsSession>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningSmsSession>()
                .HasMany(e => e.CovidScreeningSmsDetails)
                .WithRequired(e => e.CovidScreeningSmsSession)
                .HasForeignKey(e => e.SessionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CovidScreeningSmsDetail>()
                .Property(e => e.Field)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningSmsDetail>()
                .Property(e => e.MessageUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningSmsDetail>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.TxnType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.CalcAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.UserUpdated)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.StatusIcon)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.TransactionResult)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.AuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.SourceKey)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.CardInfo)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreening>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreening>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_CovidScreening>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_CovidScreening>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreening>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreening>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<CovidScreeningPhoneLog>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreeningSessions>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreeningSessions>()
                .Property(e => e.MessageUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreeningSessions>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreeningSessions>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreeningSessions>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreeningStatus>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_CovidScreeningStatus>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreeningStatus>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreeningStatus>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreeningStatus>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_CovidScreeningStatus>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_SmsPendingMessages>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<view_SmsPendingMessages>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_SmsPendingMessages>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_SmsPendingMessages>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_SmsPendingMessages>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_SmsPendingMessages>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.Bungalow)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.Debit)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.TotalPaid)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.ScheduledPayments)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.Paid)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.PreviousBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusAccounts>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<CallbackRequest>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<CallbackRequest>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CallbackRequest>()
                .Property(e => e.AssignedTo)
                .IsUnicode(false);

            modelBuilder.Entity<CallbackRequest>()
                .Property(e => e.CallbackNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_Communications>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_Communications>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<view_Communications>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_Communications>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_Communications>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<view_Communications>()
                .Property(e => e.SmsStatus)
                .IsUnicode(false);

            modelBuilder.Entity<view_Communications>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_Communications>()
                .Property(e => e.AssignedTo)
                .IsUnicode(false);

            modelBuilder.Entity<view_Communications>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Communications>()
                .Property(e => e.CallbackNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.HusbandCell1)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.HusbandCell2)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.OtherCell)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.WifeCell)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.WorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.BusinessType)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.SmartPhoneMeshimer)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.BasicPhoneMeshimer)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.HomeComputerMeshimer)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.HomeComputerFilterType)
                .IsFixedLength();

            modelBuilder.Entity<VMForm>()
                .Property(e => e.WifeWorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.WifeBusinessType)
                .IsUnicode(false);

            modelBuilder.Entity<VMForm>()
                .Property(e => e.DaughterWorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<KollelForm>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<KollelForm>()
                .Property(e => e.Cellphone)
                .IsUnicode(false);

            modelBuilder.Entity<KollelForm>()
                .Property(e => e.KollelPhone)
                .IsUnicode(false);

            modelBuilder.Entity<KollelForm>()
                .Property(e => e.KollelTime)
                .IsUnicode(false);

            modelBuilder.Entity<KollelForm>()
                .Property(e => e.RoshHakollelPhone)
                .IsUnicode(false);

            modelBuilder.Entity<KollelForm>()
                .Property(e => e.KollelAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<KollelForm>()
                .Property(e => e.KollelTime2)
                .IsUnicode(false);

            modelBuilder.Entity<KollelForm>()
                .Property(e => e.RoshHakollelPhone2)
                .IsUnicode(false);

            modelBuilder.Entity<Coupon>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<view_StudentsToScreen>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_StudentsToScreen>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_StudentsToScreen>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsToScreen>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsToScreen>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsToScreen>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsToScreen>()
                .Property(e => e.TeacherNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsToScreen>()
                .Property(e => e.Coupon)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Call>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<Call>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<Call>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<Call>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<Call>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsAll>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_StudentsAll>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_StudentsAll>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsAll>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsAll>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsAll>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Donation>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Donation>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Donation>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Donation>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donation>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.ScheduleAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerEmail>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerEmail>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerEmail>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_CustomerEmails>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<view_CustomerEmails>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_CustomerEmails>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_CustomerEmails>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_CustomerEmails>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_CustomerEmails>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_CustomerEmails>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_CustomerEmails>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_CustomerEmails>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<FoodDistributionInfo>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<FoodDistributionSiblings>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<FoodDistributionSiblings>()
                .Property(e => e.NameRecordingURL)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionInfo>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<CovidTest>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_Calls>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Calls>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_Calls>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_Calls>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<view_Calls>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusStreet)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusHouse)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusApt)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusCity)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusState)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<FoodDistribtionBox>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<FoodDistribtionBox>()
                .Property(e => e.BoxSize)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FoodDistribtionBox>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<FoodWeeklyDistribution>()
                .HasMany(e => e.FoodDistribtionBoxes)
                .WithRequired(e => e.FoodWeeklyDistribution)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.BusAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.BusAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.BusStreet)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.BusHouse)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.BusApt)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.BusCity)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.BusState)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.BoxSize)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.AlertInfo)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxes>()
                .Property(e => e.StreetSide)
                .IsUnicode(false);

            modelBuilder.Entity<FoodDistributionScan>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_FoodDistributionFeedback>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionFeedback>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionFeedback>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionFeedback>()
                .Property(e => e.LastDeliveryAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PlivoCallInstruction>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionSiblings>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_FoodDistributionSiblings>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionSiblings>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionSiblings>()
                .Property(e => e.NameRecordingURL)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionSiblings>()
                .Property(e => e.ConfirmedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Survey>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<Survey>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<FoodDistributionCoupon>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<FoodDistributionCoupon>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<FoodDistributionCoupon>()
                .Property(e => e.CouponNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.BusAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.BusAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.BusStreet)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.BusHouse)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.BusApt)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.BusCity)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.BusState)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.StreetSide)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.AlertInfo)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.House)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.BoxSize)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionScanInfo>()
                .Property(e => e.ScanType)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxIncreases>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_FoodDistributionBoxIncreases>()
                .Property(e => e.BoxeSizes)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionBoxIncreases>()
                .Property(e => e.LastBoxSizes)
                .IsUnicode(false);

            modelBuilder.Entity<FoodDistributionNotificationSetting>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.SendAlertsTo)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.SendAlertsType)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.AlertNumber2)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.AlertType2)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.AlertNumber3)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.AlertType3)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusStreet)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusHouse)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusApt)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusCity)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.BusState)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionAccountInfo>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<FoodDistributionMenuItem>()
                .Property(e => e.BoxSize)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FoodDistributionLog>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<FoodDistributionLog>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<AudioLibrary>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<AudioLibrary>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<Broadcast>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Broadcast>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Surveys>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_Surveys>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<PendingCall>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<PendingCall>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<PendingCall>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_Broadcasts>()
                .Property(e => e.FromNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_Broadcasts>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_Broadcasts>()
                .Property(e => e.TransferNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_Broadcasts>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_Broadcasts>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionLogs>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionLogs>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_FoodDistributionLogs>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<BroadcastDraftNumber>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastDrafts>()
                .Property(e => e.FromNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastDrafts>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastDrafts>()
                .Property(e => e.NumberSelectionMode)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastDrafts>()
                .Property(e => e.TransferNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastDrafts>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusTransaction>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusTransaction>()
                .Property(e => e.Year)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusTransaction>()
                .Property(e => e.Bungalow)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusTransaction>()
                .Property(e => e.UsedType)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusTransaction>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusTransactions>()
                .Property(e => e.Year)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusTransactions>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusTransactions>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusTransactions>()
                .Property(e => e.PreviousBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusTransactions>()
                .Property(e => e.Bungalow)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusTransactions>()
                .Property(e => e.Total)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusTransactions>()
                .Property(e => e.Used)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusTransactions>()
                .Property(e => e.Available)
                .HasPrecision(38, 2);

            modelBuilder.Entity<CampBroadcast>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<CampCallRecording>()
                .Property(e => e.CallSid)
                .IsUnicode(false);

            modelBuilder.Entity<CampCallRecording>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<CampCallRecording>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<CampCall>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CampCall>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<CampCall>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<CampIVRDetail>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CampIVRDetail>()
                .Property(e => e.EventType)
                .IsUnicode(false);

            modelBuilder.Entity<CampIVRDetail>()
                .Property(e => e.InputDigits)
                .IsUnicode(false);

            modelBuilder.Entity<CampIVRDetail>()
                .Property(e => e.Response)
                .IsUnicode(false);

            modelBuilder.Entity<CampStaff>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<CampStudentPhoneFilter>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<CampStudentPhoneFilter>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<CampStudentSetting>()
                .Property(e => e.LastCallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CampVoicemail>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<CampVoicemail>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<CampVoicemail>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CampBlockList>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<CampBlockList>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<CampBlockList>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CampPhoneSchedule>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<CampPhoneSchedule>()
                .Property(e => e.TimeFrom)
                .IsUnicode(false);

            modelBuilder.Entity<CampPhoneSchedule>()
                .Property(e => e.TimeTo)
                .IsUnicode(false);

            modelBuilder.Entity<CampPhoneSchedule>()
                .Property(e => e.Days)
                .IsUnicode(false);

            modelBuilder.Entity<view_DayCampEnrollmentStatus>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_DayCampEnrollmentStatus>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_DayCampEnrollmentStatus>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_DayCampEnrollmentStatus>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_DayCampEnrollmentStatus>()
                .Property(e => e.RegType)
                .IsUnicode(false);

            modelBuilder.Entity<view_DayCampEnrollmentStatus>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<view_DayCampEnrollmentStatus>()
                .Property(e => e.ClassDescription)
                .IsUnicode(false);

            modelBuilder.Entity<view_DayCampEnrollmentStatus>()
                .Property(e => e.DCWeeks)
                .IsUnicode(false);

            modelBuilder.Entity<view_DayCampEnrollmentStatus>()
                .Property(e => e.Building)
                .IsUnicode(false);

            modelBuilder.Entity<SignalwireCall>()
                .Property(e => e.CallSid)
                .IsUnicode(false);

            modelBuilder.Entity<SignalwireCall>()
                .Property(e => e.AnsweredBy)
                .IsUnicode(false);

            modelBuilder.Entity<SignalwireCall>()
                .Property(e => e.CallerName)
                .IsUnicode(false);

            modelBuilder.Entity<SignalwireCall>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<SignalwireCall>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<SignalwireCall>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<SignalwireCall>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<SignalwireCall>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<SignalwireCall>()
                .Property(e => e.Uri)
                .IsUnicode(false);

            modelBuilder.Entity<ClassSetup>()
                .Property(e => e.RegID)
                .IsFixedLength();

            modelBuilder.Entity<ClassSetup>()
                .Property(e => e.ClassType)
                .IsUnicode(false);

            modelBuilder.Entity<ClassSetup>()
                .Property(e => e.Building)
                .IsUnicode(false);

            modelBuilder.Entity<ClassSetup>()
                .Property(e => e.RoomNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCalls>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCalls>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCalls>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCalls>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCalls>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCalls>()
                .Property(e => e.BootNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCalls>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<CampCallRecordingRequest>()
                .Property(e => e.CallSid)
                .IsUnicode(false);

            modelBuilder.Entity<CampCallRecordingRequest>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<CampCallRecordingRequest>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<RewardsPlus>()
                .Property(e => e.RewardType)
                .IsUnicode(false);

            modelBuilder.Entity<RewardsPlus>()
                .Property(e => e.Credit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RewardsPlus>()
                .Property(e => e.Debit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RewardsPlus>()
                .Property(e => e.Amount)
                .HasPrecision(11, 2);

            modelBuilder.Entity<RewardsPlus>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RewardsPlusTempPin>()
                .Property(e => e.RewardType)
                .IsUnicode(false);

            modelBuilder.Entity<RewardsPlusTempPin>()
                .Property(e => e.PinNum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kiosk>()
               .Property(e => e.ComputerName)
               .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.BannerURL)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .HasMany(e => e.Kiosks)
                .WithRequired(e => e.KioskSetting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.Cellphone)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.KollelPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.KollelTime)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.KollelAllDay)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.KollelMorning)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.RoshHakollelPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.KollelTime2)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.Kollel2Afternoon)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.RoshHakollelPhone2)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.KollelPayrollYes)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.KollelPayrollNo)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.KidsEnrolledCount)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.WivesJobYears)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.WifeHasJobYes)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.WifeHasJobNo)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.HasJobYes)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.HasJobNo)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.OtherSchoolBoysCount)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.OtherSchoolTeensCount)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.OtherSchoolGirlsCount)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelForms>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<KollelFormLog>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_KollelFormLogs>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentCalls>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentCalls>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentCalls>()
                .Property(e => e.Minutes)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_StudentCalls>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentCalls>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentCalls>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentCalls>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentCalls>()
                .Property(e => e.BootNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentCalls>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolIvrDetail>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolIvrDetail>()
                .Property(e => e.EventType)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolIvrDetail>()
                .Property(e => e.InputDigits)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolIvrDetail>()
                .Property(e => e.Response)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.BranchDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.BranchRecordingFile)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.ListType)
                .IsUnicode(false);

            modelBuilder.Entity<ClassesGSF>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<ClassesGSF>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<ClassesGSF>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<ClassesGSF>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<ClassesGSF>()
                .Property(e => e.BuildingCode)
                .IsUnicode(false);

            modelBuilder.Entity<ClassesGSF>()
                .Property(e => e.Teacher)
                .IsUnicode(false);

            modelBuilder.Entity<ClassesGSF>()
                .Property(e => e.Teacher2)
                .IsUnicode(false);

            modelBuilder.Entity<ClassesGSF>()
                .Property(e => e.Teacher3)
                .IsUnicode(false);

            modelBuilder.Entity<ClassesGSF>()
                .Property(e => e.Teacher4)
                .IsUnicode(false);

            modelBuilder.Entity<ClassesGSF>()
                .Property(e => e.Room)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_ClassInfo>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_ClassInfo>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_ClassInfo>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_ClassInfo>()
                .Property(e => e.BranchRecordingFile)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_ClassInfo>()
                .Property(e => e.ListType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_ClassInfo>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_ClassInfo>()
                .Property(e => e.ClassAnnouncement)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_RegistrationClassInfo>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_RegistrationClassInfo>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_RegistrationClassInfo>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_RegistrationClassInfo>()
                .Property(e => e.BranchRecordingFile)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_RegistrationClassInfo>()
                .Property(e => e.ListType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_RegistrationClassInfo>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_RegistrationClassInfo>()
                .Property(e => e.ClassAnnouncement)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_RegistrationClassInfoExtended>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_RegistrationClassInfoExtended>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_RegistrationClassInfoExtended>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_RegistrationClassInfoExtended>()
                .Property(e => e.BranchRecordingFile)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_RegistrationClassInfoExtended>()
                .Property(e => e.ListType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_RegistrationClassInfoExtended>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_RegistrationClassInfoExtended>()
                .Property(e => e.ClassAnnouncement)
                .IsUnicode(false);

            modelBuilder.Entity<view_ClassInfo>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ClassInfo>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_ClassInfo>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<view_ClassInfo>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<view_ClassInfo>()
                .Property(e => e.Building)
                .IsUnicode(false);

            modelBuilder.Entity<view_ClassInfo>()
                .Property(e => e.BranchRecordingFile)
                .IsUnicode(false);

            modelBuilder.Entity<view_ClassInfo>()
                .Property(e => e.ClassAnnouncement)
                .IsUnicode(false);

            modelBuilder.Entity<view_ClassInfo>()
                .Property(e => e.Teacher)
                .IsUnicode(false);

            modelBuilder.Entity<view_ClassInfo>()
                .Property(e => e.Teacher2)
                .IsUnicode(false);

            modelBuilder.Entity<view_Branches>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_Branches>()
                .Property(e => e.BranchDesc)
                .IsUnicode(false);

            modelBuilder.Entity<view_Branches>()
                .Property(e => e.BranchRecordingFile)
                .IsUnicode(false);

            modelBuilder.Entity<view_Branches>()
                .Property(e => e.ListType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Branches>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<KitaAlefMessage>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<KitaAlefMessage>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<KitaAlefMessage>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<KitaAlefMessage>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<StudentPin>()
                .Property(e => e.PIN)
                .IsUnicode(false);

            modelBuilder.Entity<StudentPin>()
               .Property(e => e.PIN2)
               .IsUnicode(false);

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.Teacher)
                .IsUnicode(false);

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.Teacher2)
                .IsUnicode(false);

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_SpecialNeedsProgram>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_Feedback>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Feedback>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_Feedback>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Feedback>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolIvrDetail>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolIvrDetail>()
                .Property(e => e.EventType)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolIvrDetail>()
                .Property(e => e.InputDigits)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolIvrDetail>()
                .Property(e => e.Response)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolPhone>()
                .Property(e => e.DID)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolPhone>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolPhone>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherSetting>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherSetting>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherSetting>()
                .Property(e => e.PinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherSetting>()
                .Property(e => e.AlertTime)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.Building)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.AlertPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.PinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.AlertTime)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.ConnectionMode)
                .IsUnicode(false);

            modelBuilder.Entity<view_Teachers>()
                .Property(e => e.TipBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<BranchPhone>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolCall>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolCall>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolCall>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolCall>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolCall>()
                .Property(e => e.BootNumber)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolCall>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tip>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tip>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_Donors>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donors>()
                .Property(e => e.WeddingYear)
                .IsUnicode(false);

            modelBuilder.Entity<DonorSetting>()
                .Property(e => e.CardNum)
                .IsUnicode(false);

            modelBuilder.Entity<DonorSetting>()
                .Property(e => e.RequiredAmount)
                .HasPrecision(10, 4);

            modelBuilder.Entity<DonorSetting>()
                .Property(e => e.CardActivatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DonorSetting>()
                .Property(e => e.LastYearPledge)
                .HasPrecision(10, 4);

            modelBuilder.Entity<DonorSetting>()
                .Property(e => e.LastYearPaid)
                .HasPrecision(10, 4);

            modelBuilder.Entity<DonorSetting>()
                .Property(e => e.CardActivationConfirmedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_Tips>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<TipEntry>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<TipEntry>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_SMS>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<view_SMS>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_SMS>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_SMS>()
                .Property(e => e.MessageUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_SMS>()
                .Property(e => e.MessageType)
                .IsUnicode(false);

            modelBuilder.Entity<view_SMS>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_SMS>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<view_SMS>()
                .Property(e => e.AccountsSource)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentPickup>()
                .Property(e => e.EnteredBy)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentPickup>()
                .Property(e => e.PickupAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentPickup>()
                .Property(e => e.Messenger)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentPickup>()
                .Property(e => e.MessengerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentPickup>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentPickups>()
                .Property(e => e.EnteredBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentPickups>()
                .Property(e => e.PickupAddress)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentPickups>()
                .Property(e => e.Messenger)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentPickups>()
                .Property(e => e.MessengerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_PaymentPickups>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Messenger>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolPhones>()
                .Property(e => e.DID)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolPhones>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolPhones>()
                .Property(e => e.Branches)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolCalls>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolCalls>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolCalls>()
                .Property(e => e.Minutes)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_SchoolCalls>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolCalls>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolCalls>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolCalls>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolCalls>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolCalls>()
                .Property(e => e.BootNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_SchoolCalls>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolExternalCall>()
                .Property(e => e.CallSid)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolExternalCall>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolExternalCall>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolExternalCall>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolExternalCall>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolExternalCall>()
                .Property(e => e.BootNumber)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolExternalCall>()
                .Property(e => e.PlivoParentCallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolExternalCall>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<UnidentifiedNumber>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolPhoneAllowList>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolPhoneAllowList>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolPhoneAllowList>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.AppointmentTime)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donors>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donors>()
                .Property(e => e.WeddingYear)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.PhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.ResponseResult)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.RefNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.MonthlyAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.CurrentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.AccountMatch)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.VerifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.PublishedID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.PublishedID2)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.CCnum)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.ExpDate)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.CRFSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.TableNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.PledgeAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.DDCImport)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.PmtType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Transactions>()
                .Property(e => e.CCAuthNum)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.WeddingYear)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TransactionType)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.PhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.EnteredBy)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.MonthlyAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.PublishedID)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.PublishedID2)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.AccountMatch)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.VerifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CRFSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TableNum)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.DDCImport)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FundSetting>()
                .Property(e => e.Key)
                .IsUnicode(false);

            modelBuilder.Entity<FundSetting>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<FundSetting>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.EnteredBy)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_Appointments>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<view_Appointments>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_Appointments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_Appointments>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_Appointments>()
                .Property(e => e.EnteredBy)
                .IsUnicode(false);

            modelBuilder.Entity<TipsIvrTeacher>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<TipsIvrTeacher>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<TipsIvrTeacher>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BroadcastNumber>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastCalls>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastCalls>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastCalls>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastCalls>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastCalls>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastCalls>()
                .Property(e => e.InternalNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastCalls>()
                .Property(e => e.HangupCause)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastCalls>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastCalls>()
                .Property(e => e.AccountsSource)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastMessages>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastMessages>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastMessages>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastMessages>()
                .Property(e => e.MessageUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastMessages>()
                .Property(e => e.MessageType)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastMessages>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastMessages>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastMessages>()
                .Property(e => e.AccountsSource)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherRelation>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherRelation>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherRelation>()
                .Property(e => e.AddedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactions>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactions>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactions>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactions>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactions>()
                .Property(e => e.TeacherType)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactions>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactions>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StudentsTherapyInfo>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SummerTermSetting>()
                .Property(e => e.Term)
                .IsUnicode(false);

            modelBuilder.Entity<SummerTermSetting>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.Debit)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.TotalPaid)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.ScheduledPayments)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.Paid)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.PreviousBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCAccounts>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.TxnType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.CalcAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.UserUpdated)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.TransactionResult)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.AuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPayments>()
                .Property(e => e.SourceKey)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCStudents>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_YKCStudents>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCStudents>()
                .Property(e => e.Father)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCStudents>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCStudents>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCStudents>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCStudents>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCStudents>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCStudents>()
                .Property(e => e.RegType)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCStudents>()
                .Property(e => e.Weeks)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCDocuments>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCDocuments>()
                .Property(e => e.RegistrationStatus)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCDocuments>()
                .Property(e => e.MissingDocs)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCDocuments>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCDocuments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<RecentPage>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<RecentPage>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<CheckDetail>()
                .Property(e => e.CheckNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.TxnType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.CheckNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.CalcAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.UserUpdated)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.TransactionResult)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.AuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.SourceKey)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCPaymentDetails>()
                .Property(e => e.CardInfo)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.Bungalow)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.Debit)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.TotalPaid)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.ScheduledPayments)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.Paid)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.PreviousBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.LapidusBungalow)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.TotalLapidusCharges)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.TotalLapidusUsed)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.TotalLapidusAvailable)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusDayCampAccounts>()
                .Property(e => e.LunchDocumentStatus)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.TxnType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.CalcAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.UserUpdated)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.TransactionResult)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.AuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.SourceKey)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCUnprocessedPayments>()
                .Property(e => e.CardInfo)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.TypeID)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.HomePhoneSearch)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.CellPhoneSearch)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.Debit)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.TotalPaid)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.ScheduledPayments)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.Paid)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.Credit)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.PreviousBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.MissingDocs)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.RegistrationStatus)
                .IsUnicode(false);

            modelBuilder.Entity<view_YKCNotes>()
                .Property(e => e.HealthFormStatus)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.CallSid)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.AnsweredBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.CallerName)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.Uri)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.ParentCallSid)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampCallLogs>()
                .Property(e => e.Carrier)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.PIN)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.AvailableMinutes)
                .HasPrecision(20, 2);

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.MkStatus)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.MkBusStop)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.MkBusTime)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampStudents>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_TuitionBalanceSupper>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_TuitionBalanceSupper>()
                .Property(e => e.BilledTamuz)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_TuitionBalanceSupper>()
                .Property(e => e.BilledAv)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_TuitionBalanceSupper>()
                .Property(e => e.Balance)
                .HasPrecision(38, 0);

            modelBuilder.Entity<view_TuitionBalanceSupper>()
                .Property(e => e.TamuzEnd)
                .IsUnicode(false);

            modelBuilder.Entity<CampDistribution>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<CampDistribution>()
                .HasMany(e => e.CampDistributionChanges)
                .WithOptional(e => e.CampDistribution)
                .HasForeignKey(e => e.DistributionID);

            modelBuilder.Entity<CampFamily>()
                .HasMany(e => e.CampDistributionChanges)
                .WithOptional(e => e.CampFamily)
                .HasForeignKey(e => e.FamilyID);

            modelBuilder.Entity<CampInfo>()
                .HasMany(e => e.CampFamilies)
                .WithOptional(e => e.CampInfo)
                .HasForeignKey(e => e.CampID);

            modelBuilder.Entity<CampMenuItem>()
                .Property(e => e.ChoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<CampMenuItem>()
                .Property(e => e.DistributionType)
                .IsUnicode(false);

            modelBuilder.Entity<CampMenuItem>()
                .HasMany(e => e.CampDistributionChanges)
                .WithOptional(e => e.CampMenuItem)
                .HasForeignKey(e => e.MenuItemID);

            modelBuilder.Entity<CampMenuItem>()
                .HasMany(e => e.CampMenuItemChoices)
                .WithRequired(e => e.CampMenuItem)
                .HasForeignKey(e => e.MenuItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CampDistributionCall>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CampFoodDistributionRequest>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<CampFoodDistributionRequest>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<CampFoodDistributionRequest>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<CampDistributionLog>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<CampDistributionLog>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<CampDistributionLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampFoodDistributionRequests>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampFoodDistributionRequests>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampFoodDistributionRequests>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampFoodDistributionLogs>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampFoodDistributionLogs>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampFoodDistributionLogs>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampFoodDistributionLogs>()
                .Property(e => e.FamilyID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampDistributionIVRCalls>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampDistributionIVRCalls>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CampDistributionIVRCalls>()
                .Property(e => e.PhoneLine)
                .IsUnicode(false);

            modelBuilder.Entity<VMformsLog>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_VMFormLogs>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.Teacher)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.Teacher2)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentsNewYear>()
                .Property(e => e.CallingCardPin)
                .IsUnicode(false);

            modelBuilder.Entity<BlockedAppointmentDate>()
                .Property(e => e.EnteredBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_Kapures>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<view_Kapures>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<view_Kapures>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_Kapures>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_Kapures>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Kapures>()
                .Property(e => e.TableNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_Kapures>()
                .Property(e => e.Zchurim)
                .HasPrecision(18, 0);

            modelBuilder.Entity<view_Kapures>()
                .Property(e => e.Nakeivas)
                .HasPrecision(18, 0);

            modelBuilder.Entity<view_TipPayments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipPayments>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipPayments>()
                .Property(e => e.TeacherType)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipPayments>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipPayments>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipPayments>()
                .Property(e => e.CheckNumber)
                .IsUnicode(false);

            modelBuilder.Entity<YKStudent>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<YKStudent>()
                .Property(e => e.LName)
                .IsUnicode(false);

            modelBuilder.Entity<YKStudent>()
                .Property(e => e.Period)
                .IsUnicode(false);

            modelBuilder.Entity<YKStudent>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<YKStudent>()
                .Property(e => e.FathersCell)
                .IsUnicode(false);

            modelBuilder.Entity<YKStudent>()
                .Property(e => e.MothersCell)
                .IsUnicode(false);

            modelBuilder.Entity<TipRecording>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<TipRecording>()
                .Property(e => e.PinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolPhoneSchedule>()
                .Property(e => e.TimeFrom)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolPhoneSchedule>()
                .Property(e => e.TimeTo)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolPhoneSchedule>()
                .Property(e => e.Days)
                .IsUnicode(false);

            modelBuilder.Entity<NewAccountApplication>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<NewAccountApplication>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<NewAccountApplication>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_NewFamilyApplications>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_NewFamilyApplications>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_NewFamilyApplications>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_NewFamilyApplications>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_NewFamilyApplications>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTeacher>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTeacher>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTeacher>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTeacher>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTeacher>()
                .Property(e => e.TType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ClassTeacher>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTeacher>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersAllPositions>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersAllPositions>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersAllPositions>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersAllPositions>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersAllPositions>()
                .Property(e => e.Building)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersAllPositions>()
                .Property(e => e.AlertPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersAllPositions>()
                .Property(e => e.PinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersAllPositions>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersAllPositions>()
                .Property(e => e.BusNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherNotification>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherNotification>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherNotification>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeacherRelations>()
                .Property(e => e.AddedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeacherRelations>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.Building)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.BranchRecordingFile)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.ListType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.ClassAnnouncement)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.TeacherCode2)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceCards>()
                .Property(e => e.CardNum)
                .IsUnicode(false);

            modelBuilder.Entity<StudentIdCard>()
                .Property(e => e.CardNum)
                .IsUnicode(false);

            modelBuilder.Entity<StudentIdCard>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.Building)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.BranchRecordingFile)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.ListType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.ClassAnnouncement)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.TeacherCode2)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.CardNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_Students_AttendanceScans>()
                .Property(e => e.DeviceID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ImmunizationsByStudent>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_ImmunizationsByStudent>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_EBTData>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_EBTData>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<view_EBTData>()
                .Property(e => e.Children)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastEmails>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastEmails>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastEmails>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<view_BroadcastEmails>()
                .Property(e => e.AccountsSource)
                .IsUnicode(false);

            modelBuilder.Entity<DOE>()
                .Property(e => e.VoteHistory)
                .IsUnicode(false);

            modelBuilder.Entity<view_Matches>()
                .Property(e => e.EarlyElection)
                .IsFixedLength();

            modelBuilder.Entity<view_MasterList>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<view_DOE>()
                .Property(e => e.VoteHistory)
                .IsUnicode(false);

            modelBuilder.Entity<view_VMAccountStatus>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_VMAccountStatus>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_VMAccountStatus>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_VMAccountStatus>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.KeyValues)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.AccountLinkID)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.PinNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.BusAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.BusAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.TotalScheduledAmount)
                .HasPrecision(38, 4);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.TuitionBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.TransportationBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.RegistrationStatus)
                .IsUnicode(false);

            modelBuilder.Entity<view_AccontInfo>()
                .Property(e => e.CityStateZip)
                .IsUnicode(false);

            modelBuilder.Entity<EmailSetting>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<ImmunizationBroadcastSetting>()
                .Property(e => e.CallPhoneTypes)
                .IsUnicode(false);

            modelBuilder.Entity<ImmunizationBroadcastSetting>()
                .Property(e => e.MessagePhoneTypes)
                .IsUnicode(false);

            modelBuilder.Entity<ImmunizationBroadcastSetting>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersHighSchool>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersHighSchool>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<view_TeachersHighSchool>()
                .Property(e => e.HighSchoolCode)
                .IsUnicode(false);

            modelBuilder.Entity<GradeTerm>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<GradeTerm>()
                .Property(e => e.Grade)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusBilling>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<LapidusBilling>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusBilling>()
                .Property(e => e.UnitNum)
                .IsUnicode(false);

            modelBuilder.Entity<LapidusBilling>()
                .Property(e => e.BaseAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.SourceType)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.BungalowCharge)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.BedroomCharge)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.AirConditionersCharge)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.WasherCharge)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.DryerCharge)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.MaintenanceCharge)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.SplitCharge)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.Debit)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.TotalPaid)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.ScheduledPayments)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.Paid)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.Credit)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.ActualBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.PreviousBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.LapidusBungalow)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.TotalLapidusCharges)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.TotalLapidusUsed)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.TotalLapidusAvailable)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusBilling>()
                .Property(e => e.LunchDocumentStatus)
                .IsUnicode(false);

            modelBuilder.Entity<view_NewStudents>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_NewStudents>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_NewStudents>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_NewStudents>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<InvoiceItemCode>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceItemCode>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.LinkStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.LinkID)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<HsStudent>()
                .Property(e => e.ScreeningDate)
                .IsUnicode(false);

            modelBuilder.Entity<HsStudent>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<HsStudent>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<HsStudent>()
                .Property(e => e.FamilyPrimaryPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_HsStudents>()
                .Property(e => e.ScreeningDate)
                .IsUnicode(false);

            modelBuilder.Entity<view_HsStudents>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_HsStudents>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<view_HsStudents>()
                .Property(e => e.FamilyPrimaryPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_Search>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.TxnType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.CalcAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.UserUpdated)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.TransactionResult)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.AuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusPayments>()
                .Property(e => e.SourceKey)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.ActualBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.TxnType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.CalcAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.UserUpdated)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.TransactionResult)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.AuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.SourceKey)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusUnprocessedPayments>()
                .Property(e => e.CardInfo)
                .IsUnicode(false);

            modelBuilder.Entity<AdminPortalLogin>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<AdminPortalLogin>()
                .Property(e => e.ClientIP)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDocuments>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDocuments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDocuments>()
                .Property(e => e.UploadedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_LapidusDocuments>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_VotingRegNotes>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_VotingRegNotes>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_VotingRegNotes>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_VotingRegNotes>()
                .Property(e => e.TypeID)
                .IsUnicode(false);

            modelBuilder.Entity<view_VotingRegNotes>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<AutoMatchDetail>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<AutoMatch>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_AutoMatchDetails>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_AutoMatchDetails>()
                .Property(e => e.MatchType)
                .IsUnicode(false);

            modelBuilder.Entity<view_AutoMatches>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentAutoMatchDetails>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentAutoMatchDetails>()
                .Property(e => e.Apt)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentAutoMatchDetails>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentAutoMatchDetails>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_StudentAutoMatchDetails>()
                .Property(e => e.MatchType)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.HusbandCell1)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.HusbandCell2)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.OtherCell)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.WifeCell)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.WorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.BusinessType)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.SmartPhoneMeshimer)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.BasicPhoneMeshimer)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.HomeComputerMeshimer)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.HomeComputerFilterType)
                .IsFixedLength();

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.WifeWorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.WifeBusinessType)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.DaughterWorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_VmFormsExtended>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<AdminPortalNavigationSetting>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_NotAssignedStudents>()
                .Property(e => e.AppointmentTime)
                .IsUnicode(false);

            modelBuilder.Entity<PendingBusChange>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<ErrorLog>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<ErrorLog>()
                .Property(e => e.RequestMethod)
                .IsUnicode(false);

            modelBuilder.Entity<ErrorLog>()
                .Property(e => e.StatusCode)
                .IsUnicode(false);

            modelBuilder.Entity<ErrorLog>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<CholHamoedProgramReport>()
                .Property(e => e.Digit)
                .IsUnicode(false);

            modelBuilder.Entity<CholHamoedProgramReport>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CholHamoedProgramReports>()
                .Property(e => e.Digit)
                .IsUnicode(false);

            modelBuilder.Entity<view_CholHamoedProgramReports>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_CholHamoedProgramReports>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.TargetGoal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.GoalMultiply)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.PublishMinAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.PublishMaxAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AttendanceScan>()
                .Property(e => e.CardNum)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceScan>()
                .Property(e => e.DeviceID)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceScan>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<AttendanceScan>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceScan>()
                .Property(e => e.EnteredBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_ButcherRewards>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_ButcherRewards>()
                .Property(e => e.TxnType)
                .IsUnicode(false);

            modelBuilder.Entity<view_ButcherRewards>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_ButcherRewards>()
                .Property(e => e.RedeemType)
                .IsUnicode(false);

            modelBuilder.Entity<view_ButcherRewards>()
                .Property(e => e.AddedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_YgStudentsList>()
                .Property(e => e.SsnLast4)
                .IsUnicode(false);

            modelBuilder.Entity<view_YgStudentsList>()
                .Property(e => e.Apt)
                .IsUnicode(false);

            modelBuilder.Entity<view_YgStudentsList>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<KesherCustomRelation>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<KesherCustomRelation>()
                .Property(e => e.AddedBy)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployeePosition>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployeePosition>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployeePosition>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployeePosition>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployeePosition>()
                .Property(e => e.BusNum)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployeePosition>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployee>()
                .Property(e => e.KesherNum)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployee>()
                .Property(e => e.NameRecording)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployee>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployee>()
                .Property(e => e.PinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployee>()
                .Property(e => e.AlertTime)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployee>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<KesherEmployee>()
                .HasMany(e => e.KesherEmployeePositions)
                .WithRequired(e => e.KesherEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KesherEmployee>()
                .HasMany(e => e.KesherTips)
                .WithRequired(e => e.KesherEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KesherParentBalanceTransaction>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KesherParentBalanceTransaction>()
                .Property(e => e.Amount)
                .HasPrecision(8, 2);

            modelBuilder.Entity<KesherPositionType>()
                .Property(e => e.PositionCode)
                .IsUnicode(false);

            modelBuilder.Entity<KesherPositionType>()
                .Property(e => e.PositionRecording)
                .IsUnicode(false);

            modelBuilder.Entity<KesherPositionType>()
                .HasMany(e => e.KesherEmployeePositions)
                .WithRequired(e => e.KesherPositionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KesherTip>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KesherTip>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<KesherTip>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<KesherTip>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<KesherTip>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.Building)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.TeacherCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.BusNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.KesherNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.Teacher)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.TeacherNameRecording)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.AlertPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.PinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.AlertTime)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_KesherEmployees>()
                .Property(e => e.TipBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_TipTransactionsNew>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactionsNew>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactionsNew>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactionsNew>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_TipTransactionsNew>()
                .Property(e => e.CheckNumber)
                .IsUnicode(false);

            modelBuilder.Entity<KesherTipAcknowledgment>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<KesherTipAcknowledgment>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<KesherTipAcknowledgment>()
                .Property(e => e.ToNumber)
                .IsUnicode(false);

            modelBuilder.Entity<KesherTipAcknowledgment>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<KesherTipAcknowledgment>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<KesherStatement>()
                .Property(e => e.UserCreated)
                .IsUnicode(false);

            modelBuilder.Entity<BroadcastContact>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BroadcastContact>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<BroadcastContact>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.AccountID)
                .IsFixedLength();

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.ActualBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.TxnType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.CalcAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.UserUpdated)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.RegID)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.StatusValue)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.TransactionResult)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.AuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.SourceKey)
                .IsUnicode(false);

            modelBuilder.Entity<view_UnprocessedPayments>()
                .Property(e => e.CardInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Buses>()
                .Property(e => e.BusNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Driver_Bus>()
                .HasMany(e => e.DriverAbsents)
                .WithOptional(e => e.Driver_Bus)
                .HasForeignKey(e => e.Driver_Bus_ID);

            modelBuilder.Entity<Driver_Bus>()
                .HasMany(e => e.RouteSchedules)
                .WithOptional(e => e.Driver_Bus)
                .HasForeignKey(e => e.Driver_Bus_ID);

            modelBuilder.Entity<Route>()
                .Property(e => e.Term)
                .IsUnicode(false);

            modelBuilder.Entity<Route>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<Route>()
                .HasMany(e => e.DriverAbsents)
                .WithOptional(e => e.Route)
                .HasForeignKey(e => e.Route_ID);

            modelBuilder.Entity<Route>()
                .HasMany(e => e.RouteSchedules)
                .WithOptional(e => e.Route)
                .HasForeignKey(e => e.Route_ID);

            modelBuilder.Entity<RouteSchedule>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_Buses>()
                .Property(e => e.BusNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TempTransportationRoute>()
                .Property(e => e.Num)
                .IsUnicode(false);

            modelBuilder.Entity<TempTransportationRoute>()
                .Property(e => e.BusNum)
                .IsUnicode(false);

            modelBuilder.Entity<view_Driver_Bus>()
                .Property(e => e.BusNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.Campaign)
                .IsUnicode(false);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.ScheduleAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_YearBookAdDonations>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<view_Routes>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_Routes>()
                .Property(e => e.Term)
                .IsUnicode(false);

            modelBuilder.Entity<view_Routes>()
                .Property(e => e.TimeStart)
                .IsUnicode(false);

            modelBuilder.Entity<view_Routes>()
                .Property(e => e.BusNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_DriverAbsent>()
                .Property(e => e.Term)
                .IsUnicode(false);

            modelBuilder.Entity<view_DriverAbsent>()
                .Property(e => e.TimeStart)
                .IsUnicode(false);

            modelBuilder.Entity<view_DriverAbsent>()
                .Property(e => e.BusNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_CholHamoedProgramStudents>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_CholHamoedProgramStudents>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_CholHamoedProgramStudents>()
                .Property(e => e.PointsBalance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<view_CholHamoedProgramStudents>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.Campaign)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.ScheduleAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<view_Donations>()
                .Property(e => e.CardNumLast5)
                .IsUnicode(false);

            modelBuilder.Entity<VotingRegstrationFormStatus>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<VotingRegstrationFormStatus>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_VotingRegstrationFormStatus>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<view_VotingRegstrationFormStatus>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalNoteField>()
                .Property(e => e.Offered)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AdditionalNoteField>()
                .Property(e => e.CounterOffer)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Token>()
                .Property(e => e.Token1)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.RequesterEmail)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.SMSMail)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.UserScope)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.SMSMailID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.CostPerHour)
                .HasPrecision(11, 2);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.SiteName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.SiteID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.PhotoURL)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.DepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.DepartmentID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.JobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TemplateName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TemplateID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.CreatedTimeDisplayValue)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.CreatedTimeValue)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.CancelFlagComments)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.DisplayID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.OnBehalfOf)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianEmail)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianSMSMail)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianMobile)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianLastName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianUserScope)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianSMSMailID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianCostPerHour)
                .HasPrecision(11, 2);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianSiteID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianPhone)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianEmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianPhotoURL)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianDepartmentID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.TechnicianJobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.DueByTimeDisplayValue)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.DueByTimeValue)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.Maintenance)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.StatusInternalName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.StatusColor)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineRequest>()
                .Property(e => e.StatusID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineUser>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineUser>()
                .Property(e => e.RequesterID)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineUser>()
                .Property(e => e.RequesterEmail)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineUser>()
                .Property(e => e.RequesterName)
                .IsUnicode(false);

            modelBuilder.Entity<ManageengineUser>()
                .Property(e => e.MatchedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.ManageengineID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.RequesterEmail)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.SMSMail)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.UserScope)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.SMSMailID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.CostPerHour)
                .HasPrecision(11, 2);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.SiteName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.SiteID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.PhotoURL)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.DepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.DepartmentID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.JobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TemplateName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TemplateID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.CreatedTimeDisplayValue)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.CreatedTimeValue)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.CancelFlagComments)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.DisplayID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.OnBehalfOf)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianEmail)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianSMSMail)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianMobile)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianLastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianUserScope)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianSMSMailID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianCostPerHour)
                .HasPrecision(11, 2);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianSiteID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianPhone)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianEmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianPhotoURL)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianDepartmentID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianJobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.DueByTimeDisplayValue)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.DueByTimeValue)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.Maintenance)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.StatusInternalName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.StatusColor)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.StatusID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.TechnicianID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.RequesterID)
                .IsUnicode(false);

            modelBuilder.Entity<view_ManageengineRequests>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<view_FormCards>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_FormCards>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<view_FormCards>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<view_FormCards>()
                .Property(e => e.Sename)
                .IsUnicode(false);

            modelBuilder.Entity<view_FormCards>()
                .Property(e => e.Sbarcode)
                .IsFixedLength();

            modelBuilder.Entity<TuitionDiscountRequest>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<TuitionDiscountRequest>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<TuitionDiscountRequest>()
                .Property(e => e.AssignedTo)
                .IsUnicode(false);

            modelBuilder.Entity<TuitionDiscountRequest>()
                .Property(e => e.CallbackNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TuitionDiscountRequest>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_TuitionDiscountRequests>()
                .Property(e => e.CallerID)
                .IsUnicode(false);

            modelBuilder.Entity<view_TuitionDiscountRequests>()
                .Property(e => e.CallUUID)
                .IsUnicode(false);

            modelBuilder.Entity<view_TuitionDiscountRequests>()
                .Property(e => e.AssignedTo)
                .IsUnicode(false);

            modelBuilder.Entity<view_TuitionDiscountRequests>()
                .Property(e => e.CallbackNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_TuitionDiscountRequests>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_AdminPortalUsers>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<view_AdminPortalUsers>()
                .Property(e => e.UtaPhone)
                .IsFixedLength();

            modelBuilder.Entity<CreditCardUser>()
                .Property(e => e.EnteredBy)
                .IsUnicode(false);

            modelBuilder.Entity<CreditCardUser>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<view_ApplicantStudents>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<view_ApplicantStudents>()
                .Property(e => e.FamilyID)
                .IsFixedLength();

            modelBuilder.Entity<view_ApplicantStudents>()
                .Property(e => e.EngName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ApplicantStudents>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<view_ApplicantStudents>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<view_ApplicantStudents>()
                .Property(e => e.ByUser)
                .IsUnicode(false);

            modelBuilder.Entity<view_ApplicantStudents>()
                .Property(e => e.TeacherNumber)
                .IsUnicode(false);

            modelBuilder.Entity<view_ApplicantStudents>()
                .Property(e => e.Coupon)
                .HasPrecision(18, 0);

            modelBuilder.Entity<view_ApplicantStudents>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<view_ApplicantStudents>()
                .Property(e => e.VotingStatus)
                .IsUnicode(false);
        }
    }
}
