namespace PRJ.Utility;

public class SessionProperty
{
    public const string UserId = "UserId";
    public const string Name = "Name";
    public const string RoleId = "RoleId";
    public const string Role = "Role";
    public const string Email = "Email";
    public const string Photo = "Photo";
    public const string Timezone = "Timezone";
}

public static class StripeKey
{
    public const string ApiKey = "sk_test_51MEvEGJx6a3z1tBaZqW3Tr5UxYdKr8Vj9mut3oyp3vAxguWBnTxiHve1MQOngJCUvBbUe1fbpuHJ5tgAAE78OaoU00xGU879gQ";
    public const string WebhookEndpointSecret = "whsec_8q6H8NayEfPWP7bNVqRiribMGA6zLlG2";
    public const string TestWebhookEndpointSecret = "whsec_cedogwG7QVNap2WCEQtzMtpAinU5lT2k";

}

public class OTPMedium
{
    public const int PhoneNumber = 5;
    public const int Email = 6;
   
}

public class Roles
{
    public const int Admin = 1;
    public const int Doctor = 2;
    public const int Patient = 3;
    public const int Staff = 4;
}

public class AppointmentStatus
{
    public const int Completed = 142;
    public const int Missed = 143;
    public const int Cancelled = 144;
    public const int Booked = 145;
}

public class AppointmentType
{
    public const int New = 146;
    public const int FollowUp = 147;
}

public class AppointmentListingTypes
{
    public const string Upcoming = "Upcoming";
    public const string Past = "Past";
}

public class MedicationListTypes
{
    public const string Current = "Current";
    public const string Past = "Past";
}

public class PlanTypes
{
    public const int Subscription = 156;
    public const int À_la_Carte = 155;
}