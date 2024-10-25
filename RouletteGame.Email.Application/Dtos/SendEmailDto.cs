namespace RouletteGame.Email.Application.Dtos;

public class SendEmailDto
{
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}