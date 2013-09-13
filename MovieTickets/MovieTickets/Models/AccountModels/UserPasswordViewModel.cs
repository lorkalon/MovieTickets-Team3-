using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models.AccountModels
{
    public class UserPasswordViewModel
    {
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }
        [Required]
        [Display(Name = "Confirm new password")]
        public string ConfirmNewPassword { get; set; }
    }
}
