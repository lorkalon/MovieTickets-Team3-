using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models.AccountModels
{
    public class UserProfileViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Date of registration")]
        public System.DateTime Date { get; set; }
    }
}
