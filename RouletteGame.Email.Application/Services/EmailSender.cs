using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using RouletteGame.Email.Application.interfaces;

namespace RouletteGame.Email.Application.Services;

public class EmailSender : IEmailSender
{
    private readonly string _smtpServer;
    private readonly int _smtpPort;
    private readonly string _emailAddress;
    private readonly string _emailPassword;

    public EmailSender(IConfiguration configuration)
    {
        _smtpServer = configuration["EmailSettings:SmtpServer"];
        _smtpPort = int.Parse(configuration["EmailSettings:SmtpPort"]);
        _emailAddress = configuration["EmailSettings:EmailAddress"];
        _emailPassword = configuration["EmailSettings:EmailPassword"];
    }

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        using (var client = new SmtpClient(_smtpServer, _smtpPort))
        {
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(_emailAddress, _emailPassword);

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_emailAddress),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            mailMessage.To.Add(to);

            await client.SendMailAsync(mailMessage);
        }
    }
}