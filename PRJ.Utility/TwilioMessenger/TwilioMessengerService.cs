using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace PRJ.Utility.TwilioMessenger;

public class TwilioMessengerService
{
    public TwilioMessengerService()
    {
    }
    public static async Task SendMessage(string message, string phoneNumber)
    {
        TwilioClient.Init(ConfigurationStrings.testAccountSID, ConfigurationStrings.testAuthToken);

        await MessageResource.CreateAsync(
            body: message,
            from: new Twilio.Types.PhoneNumber(ConfigurationStrings.SenderPhoneNo),
            to: new Twilio.Types.PhoneNumber(phoneNumber)
        );
    }
}
