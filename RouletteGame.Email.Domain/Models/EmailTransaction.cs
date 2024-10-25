namespace RouletteGame.Email.Domain.Models;

public class EmailTransaction
{
    public int Id { get; set; } // Use 'int' for database auto-incrementing ID
    public string SentEmailName { get; set; }
    public string Subject { get; set; }
    public DateTime SentDate { get; set; }
}