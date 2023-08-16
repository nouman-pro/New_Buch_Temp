using SendGrid.Helpers.Mail;
using SendGrid;
using Microsoft.Extensions.Configuration;
using SendGrid.Helpers.Mail.Model;
using Newtonsoft.Json.Linq;

namespace PRJ.Utility.SendGrid;

public static class SendGridService
{
    //public static async Task<Response> SendAsync(IConfiguration configuration, string email, string subject, string htmlMessage, string ccEmails, string replyTo)
    //{
    //    var client = new SendGridClient(configuration.GetSection("SendGrid:Key").Value);
    //    var msg = new SendGridMessage()
    //    {
    //        From = new EmailAddress(configuration.GetSection("SendGrid:Email").Value, configuration.GetSection("SendGrid:Username").Value),
    //        Subject = subject,
    //        PlainTextContent = htmlMessage,
    //        HtmlContent = htmlMessage
    //    };
    //    if (!string.IsNullOrEmpty(ccEmails))
    //    {
    //        foreach (var ccEmail in ccEmails.Split(","))
    //        {
    //            msg.AddCc(new EmailAddress(ccEmail));
    //        }
    //    }
    //    if (!string.IsNullOrEmpty(replyTo))
    //        msg.SetReplyTo(new EmailAddress(replyTo));

    //    msg.AddTo(new EmailAddress(email));

    //    // Disable click tracking.
    //    // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
    //    msg.SetClickTracking(false, false);

    //    return await client.SendEmailAsync(msg);
    //}


    public async static Task SendAsyncMultipleEmailsToMultipleRecipients(List<EmailAddress> toEmail, List<string> subject, string messageString, List<Dictionary<string, string>> substitutions)
    {
        try
        {
            var client = new SendGridClient(SendGridKey.Key);

            //var message = new SendGridMessage()
            //{
            //    From = new EmailAddress(SendGridKey.Email, SendGridKey.Username),
            //    Subject = subject,
            //    PlainTextContent = messageString,
            //    HtmlContent = messageString,
            //};
            //CreateSingleEmailToMultipleRecipients(EmailAddress from, List<EmailAddress> tos, string subject, string plainTextContent, string htmlContent)



            var From = new EmailAddress(SendGridKey.Email, SendGridKey.Username);
            var Tos = toEmail;

            var Subject = subject;
            var PlainTextContent = messageString;
            var HtmlContent = messageString;
            var msg = MailHelper.CreateMultipleEmailsToMultipleRecipients(From,
                                                                            Tos,
                                                                            Subject,
                                                                            PlainTextContent,
                                                                            HtmlContent,
                                                                            substitutions
                                                                            );
            var response = await client.SendEmailAsync(msg);
            //message.AddTo(new EmailAddress { Email = toEmail });

            // message.SetClickTracking(false, false);
            // return client.SendEmailAsync(message);

        }
        catch (Exception ex)
        {

            throw ex;
        }
       
    }

    public async static Task SendAsyncEmail(string toEmail, string subject, string messageString)
    {
        var client = new SendGridClient(SendGridKey.Key);
        var message = new SendGridMessage()
        {
            From = new EmailAddress(SendGridKey.Email, SendGridKey.Username),
            Subject = subject,
            PlainTextContent = messageString,
            HtmlContent = messageString,
        };


        message.AddTo(new EmailAddress { Email = toEmail });
        message.SetClickTracking(false, false);
        var res = await client.SendEmailAsync(message);
      //  return res;
    }

    //public static async Task<bool> sendEmail(IConfiguration configuration, string email, string messageString, string subject)
    //{
    //    try
    //    {
    //        var response = await SendGridService.SendAsync(configuration, email, subject, messageString, null, null);
    //        return response.IsSuccessStatusCode;
    //    }
    //    catch (Exception)
    //    {
    //        return false;
    //    }
    //}
}
