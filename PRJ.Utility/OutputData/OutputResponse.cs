using Newtonsoft.Json;

namespace PRJ.Utility.OutputData;
public static class ResponseStatusCode
{
    public const int GET = 200;
    public const int CREATE = 201;
    public const int NOT_FOUND = 404;
    public const int EXIST = 409;
    public const int BAD_REQUEST = 500;
}
public static class ResponseMessage
{
    public const string Update = "Record updated successfully";
    public const string DELETE = "Record deleted successfully";
    public const string BAD_REQUEST = "The server was unable to process the request.";
    public const string GET = "Records get successfully";
    public const string NOT_FOUND = "Record not found";
    public const string RECORD_CREATE = "Record created successfully";
    public const string RECORD_UPDATE = "Record updated successfully";
    public const string RECORD_DELETE = "Record deleted successfully";
    public const string USER_CREATE = "User is created successfully";
    public const string USER_UPDATE = "User updated successfully";
    public const string USER_DELETE = "User  deleted successfully";
    public const string USER_EXIST = "User already exist";
    public const string USER_NOT_FOUND = "User does not exist";
    public const string GET_USER = "Record gets successfully";
    public const string GET_ALL_USERS = "Records get successfully";
    public const string INVALID_CREDENTIALS = "Invalid Email/Password";
    public const string SUCCESSFULLY_LOGIN = "You are successfully loggedin";
    public const string EMAIL_EXIST = "Email already exists";
    public const string PHONE_EXIST = "Phone number already exists";
    public const string SUCCESSFULLY_REGISTER = "We have sent you a one time code on your provided email/phone number. Please enter this code to activate your account.";
    public const string BLOCKED_USER = "This user is in-active";
    public const string PASSWORD_UPDATED = "Your password has been updated successfully";
    public const string OTP_VERIFIED = "Your account is successfully verified.Please login with your credentials on next step";
    public const string EMAIL_VERIFIED = "Email is verified and OTP has been sent to registered email/phone number";
    public const string OTP_SENT = "OTP has been sent successfully";
    public const string WRONG_OTP = "Invalid OTP";
    public const string SLOT_ALREADY_EXIST = "Slot already exist";
    public const string Total_Slots_Time_Is_Less_Than_DurationPlusGap = "Total slots time should be greater than duration + gap time";
    public const string Reason_Required = "Reason is Required";
    public const string Appointment_Already_Booked = "Your appointment at this time has already been booked";
    public const string Your_Appointment_Not_Booked_Yet = "Your Appointment Not Booked Yet";
    public const string Your_Appointment_Cant_be_Canceled = "Your request cannot be processed because your remaining appointment time is less than 24 hours.";
    public const string ACCOUNT_REJECTED = "Your registration has been rejected by the Admin";
    public const string ACCOUNT_SUSPENDED = "Your account has been suspended ";
    public const string RECORD_EXIST = "Record already exist";
    public const string Strip_CustomerId_Not_Generated_Yet = "Stripe CustomerId Not Generated Yet";
    public const string Strip_Card_Not_Added = "Stripe Card Not Added";
    public const string Subscription_Already_Canceled = "Subscription Already Canceled";
    public const string Subscription_Canceled = "Subscription Canceled";
    public const string Strip_SubscriptionId_Not_Generated_Yet = "Stripe SubscriptionId Not Generated Yet";
    public const string FamilyMember_Created = "Family Member is added successfully and Password has been sent to the registered email";
    public const string RECORD_Already__Exist = "Record Already Exist";
}




public static class ResponseCode
{
    public const int GET = 1;
    public const int NOT_FOUND = 2;
    public const int USER_CREATE = 3;
    public const int USER_UPDATE = 4;
    public const int USER_DELETE = 5;
    public const int USER_EXIST = 6;
    public const int USER_NOT_FOUND = 7;
    public const int GET_USER = 8;
    public const int GET_ALL_USERS = 9;
    public const int INVALID_CREDENTIALS = 10;
    public const int SUCCESSFULLY_LOGIN = 11;
    public const int EMAIL_EXIST = 12;
    public const int SUCCESSFULLY_REGISTER = 13;
    public const int BLOCKED_USER = 14;
    public const int PASSWORD_UPDATED = 15;
    public const int OTP_VERIFIED = 16;
    public const int EMAIL_VERIFIED = 17;
    public const int OTP_SENT = 18;
    public const int WRONG_OTP = 19;
    public const int PHONE_EXIST = 20;
    public const int RECORD_CREATE = 21;
    public const int RECORD_UPDATE = 22;
    public const int RECORD_DELETE = 23;
    public const int SLOT_ALREADY_EXIST = 24;
    public const int Total_Slots_Time_Is_Less_Than_DurationPlusGap = 25;
    public const int Reason_Required = 26;
    public const int Appointment_Already_Booked = 27;
    public const int Your_Appointment_Not_Booked_Yet = 28;
    public const int Your_Appointment_Cant_be_Canceled = 29;
    public const int ACCOUNT_REJECTED = 30;
    public const int ACCOUNT_SUSPENDED = 31;
    public const int RECORD_EXIST = 32;
    public const int Strip_CustomerId_Not_Generated_Yet = 33;
    public const int Strip_Card_Not_Added = 34;
    public const int Subscription_Already_Canceled = 35;
    public const int Subscription_Canceled = 36;
    public const int Strip_SubscriptionId_Not_Generated_Yet = 37;
    public const int FamilyMember_Created = 38; 
    public const int RECORD_Already__Exist = 39;
}
public class UserMessagesStrings
{
    public static string welcomeEmailSubject = "Wecome to IntelliHealth";
    public static string welcomeMessage = "Hi {0},  You are registered in IntelliHealth, please use this OTP to verify your account! OTP:{1}";
    public static string emailSubject = "OTP Verification - IntelliHealth";
    public static string ResetPasswordMessage = "Hi {0},  You can reset your password using this link <a href='{1}'>Reset Password</a>";

    public static string patientRegistrationCredentials = "Hi {0},  Your are registered in IntelliHealth, your PhoneNumber = {1} , Password = {2}";
    public static string approvedRequestSubject = "IntelliHealth Approved Request";
    public static string rejectedRequestSubject = "IntelliHealth Reject Request";
    public static string administratorRequiredAddionalInformation = "Administrator Required Addional Information";
    public static string approvedRequest = "Hi {0},  Your request has been approved from IntelliHealth admin, you can login to your account.";
    public static string rejectRequest = "Hi {0},  Your request has been rejected from IntelliHealth admin, please upload CV again.";
    public static string articleBlocked = "Your Blog/Article has been blocked by Admin";
    public static string appointmentStatus = "Appointment Status";
    public static string planStatus = "Subscription Plan Status";
}



