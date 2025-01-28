namespace BlogProject.Models.Repositories.Abstract
{

    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
