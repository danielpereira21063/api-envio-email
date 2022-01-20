using SendEmailTeste.Models;

namespace SendEmailTeste.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(EmailRequest emailRequest);
    }
}
