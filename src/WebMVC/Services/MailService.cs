using Domain.Settings;

using WebMVC.Services.Base;
using WebMVC.ViewModels.Mails;
using Microsoft.Extensions.Options;
using MailKit.Security;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

namespace WebMVC.Services;

public class EmailService:IEmailService
{
    public EmailService(IOptions<MailSetting> mailSetting)
    {
        MailSetting = mailSetting.Value;
    }

    public MailSetting MailSetting { get; }
    public Task SendEmailAsync(SendEmailRequest request)
    {
        throw new NotImplementedException();
    }

    public void SendEmail(SendEmailRequest request)
    {
        
        InternetAddressList list = new InternetAddressList();

        foreach (var address in request.To)
        {
            list.Add(MailboxAddress.Parse(address));
        }

        // create message
        var mail = new MimeMessage();

        // create message
        mail.From.Add(MailboxAddress.Parse(MailSetting.Sender));
        mail.To.AddRange(list);
        mail.Subject = request.Subject;
        mail.Body = new TextPart(TextFormat.Html) { Text = request.Body };

        // send email
        SmtpClient smtp = new SmtpClient();
        smtp.Connect(MailSetting.SmtpHost, MailSetting.SmtpPort, SecureSocketOptions.StartTls);
        smtp.Authenticate(MailSetting.SmtpUser, MailSetting.SmtpPass);
        smtp.Send(mail);
        smtp.Disconnect(true);
    }
}