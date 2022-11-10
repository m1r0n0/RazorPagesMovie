using Microsoft.AspNetCore.Identity;

namespace RazorPagesMovie.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }  
    }
}
