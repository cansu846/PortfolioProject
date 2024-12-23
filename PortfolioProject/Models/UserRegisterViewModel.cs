using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter name...")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter surname...")]
        public string SurName { get; set; }

        //[Required(ErrorMessage = "Please fill field..")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Please enter username...")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password...")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirmation password...")]
        [Compare("Password",ErrorMessage = "Passwords must be match !")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter email...")]
        [EmailAddress()]
        public string Email { get; set; }


    }
}
