using WebMVC.ViewModels.Mails;

namespace WebMVC.Services.Base;

public interface IEmailService
{
    Task SendEmailAsync(SendEmailRequest request);

    void SendEmail(SendEmailRequest request);
}