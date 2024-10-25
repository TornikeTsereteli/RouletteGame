using RouletteGame.Email.Domain.Models;

namespace RouletteGame.Email.Application.interfaces;

public interface IEmailSenderService
{
    Task<List<EmailTransaction>> GetAllEmail();
    Task SendEmail(string to, string subject, string body);

}