using RouletteGame.Email.Application.interfaces;
using RouletteGame.Email.Domain.Models;

namespace RouletteGame.Email.Application.Services;

public class EmailServiceSender : IEmailSenderService
{
    private readonly IEmailSender _emailSender;

    public EmailServiceSender(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public async Task<List<EmailTransaction>> GetAllEmail()
    {
        throw new NotImplementedException();
    }

    public async Task SendEmail(string to, string subject, string body)
    {
       await _emailSender.SendEmailAsync(to,subject,body);
    }
}