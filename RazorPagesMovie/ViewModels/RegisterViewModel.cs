using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.ViewModels
{
    public class RegisterViewModel
    {
        [Key]
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;
  
        [Required]
        [Display(Name = "Year of birth")]
        public int Year { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Compare("Password", ErrorMessage = "Passwords doesn't match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; } = string.Empty;
    }
}