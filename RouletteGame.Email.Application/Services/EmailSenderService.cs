using RouletteGame.Email.Application.interfaces;
using RouletteGame.Email.Domain.Interfaces;
using RouletteGame.Email.Domain.Models;

namespace RouletteGame.Email.Application.Services;

public class EmailSenderService : IEmailSenderService
{
    private readonly IEmailSender _emailSender;
    private readonly IEmailTransactionRepository _emailTransactionRepository;

    public EmailSenderService(IEmailSender emailSender, IEmailTransactionRepository emailTransactionRepository)
    {
        _emailSender = emailSender;
        _emailTransactionRepository = emailTransactionRepository;
    }


    public async Task<IList<EmailTransaction>> GetAllEmail()
    {
        
        return await _emailTransactionRepository.GetAllEmialTransactionsAsync();
    }

    public async Task SendEmail(string to, string subject, string body)
    {
       await _emailSender.SendEmailAsync(to,subject,body);
       await _emailTransactionRepository.AddEmailTransaction(new EmailTransaction()
       {
           SentDate = DateTime.Now,
           SentEmailName = to,
           Subject = subject
       });
    }
}