using Microsoft.AspNetCore.Identity;

namespace WebApp1.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}