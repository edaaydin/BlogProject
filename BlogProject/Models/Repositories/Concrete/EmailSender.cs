namespace BlogProject.Models.Repositories.Concrete
{
    using BlogProject.Models.Repositories.Abstract;
    using System.Net;
        using System.Net.Mail;
        using System.Threading.Tasks;

        public class EmailSender : IEmailSender
        {
            private readonly string _smtpServer = "smtp.gmail.com"; // Gmail kullanıyoruz
            private readonly int _smtpPort = 587;
            private readonly string _emailFrom = "your-email@gmail.com";
            private readonly string _emailPassword = "your-password"; // Güvenlik için bir çevre değişkeninde saklayın

            public async Task SendEmailAsync(string email, string subject, string message)
            {
                var client = new SmtpClient(_smtpServer, _smtpPort)
                {
                    Credentials = new NetworkCredential(_emailFrom, _emailPassword),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_emailFrom),
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true
                };

                mailMessage.To.Add(email);

                await client.SendMailAsync(mailMessage);
            }
        }
    }
