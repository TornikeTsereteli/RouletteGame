namespace RouletteGame.Email.Application.interfaces;

public interface IEmailSender
{
    Task SendEmailAsync(string to, string subject, string body);
}