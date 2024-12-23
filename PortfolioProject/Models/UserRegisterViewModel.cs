using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please fill field..")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please fill field..")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please fill field..")]
        [Compare("Password",ErrorMessage = "Passwords must be match !")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please fill field..")]
        public string Email { get; set; }


    }
}
