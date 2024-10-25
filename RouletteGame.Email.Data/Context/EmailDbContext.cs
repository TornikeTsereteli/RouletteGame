using Microsoft.EntityFrameworkCore;
using RouletteGame.Email.Domain.Models;

namespace RouletteGame.Email.Data.Context;
public class EmailDbContext : DbContext
{
    public EmailDbContext(DbContextOptions<EmailDbContext> options) : base(options) { }

    public DbSet<EmailTransaction> EmailTransactions { get; set; }
}
