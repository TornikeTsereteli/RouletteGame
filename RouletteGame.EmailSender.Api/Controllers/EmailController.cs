using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using RouletteGame.Email.Application.Dtos;
using RouletteGame.Email.Application.interfaces;
using RouletteGame.Email.Domain.Models;

namespace RouletteGame.EmailSender.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmailController : ControllerBase
{


    private readonly IEmailSenderService _emailSenderService;

    public EmailController(IEmailSenderService emailSenderService)
    {
        _emailSenderService = emailSenderService;
    }

    [HttpGet("GetAllEmails")]
    public async Task<IList<EmailTransaction>> GetAllSentEmail()
    {
        return await _emailSenderService.GetAllEmail();
    }

    [HttpPost("SendEmail")]
    public async Task<IActionResult> SendEmail([FromBody] SendEmailDto emailDto) // some SendEmail Request so tell 
    {
        await _emailSenderService.SendEmail(emailDto.To, emailDto.Subject, emailDto.Body);
        return Ok("SuccessFully");
    }
    
}