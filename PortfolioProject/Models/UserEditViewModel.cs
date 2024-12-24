using Microsoft.AspNetCore.Http;

namespace PortfolioProject.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
