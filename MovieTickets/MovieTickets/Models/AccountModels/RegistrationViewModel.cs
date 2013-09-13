using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models.AccountModels
{
    public class RegistrationViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }
    }
}