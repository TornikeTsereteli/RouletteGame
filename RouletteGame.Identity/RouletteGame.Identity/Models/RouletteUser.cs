using Microsoft.AspNetCore.Identity;

namespace RouletteGame.Identity.Models;

public class RouletteUser : IdentityUser
{
    public decimal Balance { get; set; }
    
}