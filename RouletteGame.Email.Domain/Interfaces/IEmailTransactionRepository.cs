using RouletteGame.Email.Domain.Models;

namespace RouletteGame.Email.Domain.Interfaces;

public interface IEmailTransactionRepository
{
    Task<IList<EmailTransaction>> GetAllEmialTransactionsAsync();
    Task AddEmailTransaction(EmailTransaction emailTransaction);
}