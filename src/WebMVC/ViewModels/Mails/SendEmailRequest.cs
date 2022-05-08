namespace WebMVC.ViewModels.Mails;

public class SendEmailRequest
{
    public List<string> To { get; set; }
    public string Subject { get; set; }
    public  string Body { get; set; }   
}