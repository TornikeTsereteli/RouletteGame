using RouletteGame.Email.Data.Context;
using RouletteGame.Email.Domain.Interfaces;
using RouletteGame.Email.Domain.Models;

namespace RouletteGame.Email.Data.Repositories;

public class EmailTransactionRepository : IEmailTransactionRepository
{

    private readonly EmailDbContext _emailDbContext;

    public EmailTransactionRepository(EmailDbContext emailDbContext)
    {
        _emailDbContext = emailDbContext;
    }

    public async Task<IList<EmailTransaction>> GetAllEmialTransactionsAsync()
    { 
        return _emailDbContext.EmailTransactions.ToList();
    }

    public async Task AddEmailTransaction(EmailTransaction emailTransaction)
    {
       _emailDbContext.EmailTransactions.Add(emailTransaction);
       await _emailDbContext.SaveChangesAsync();
    }
}