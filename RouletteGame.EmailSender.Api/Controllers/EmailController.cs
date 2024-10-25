using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace RouletteGame.EmailSender.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmailController : ControllerBase
{


    [HttpGet("GetAllEmails")]
    public async Task<IList<object>> GetAllSentEmail()
    {
        return [];
    }

    [HttpPost("SendEmail")]
    public async Task<IActionResult> SendEmail() // some SendEmail Request so tell 
    {
        return Ok("user Successfully Logged in");
    }
    
}