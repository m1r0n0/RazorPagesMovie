using Microsoft.AspNetCore.Identity;

namespace RazorPagesMovie.Models
{
    public class User : IdentityUser
    {
        public int UserID { get; set; }
        public string Email { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Password { get; set; } = string.Empty;

    }
}
