using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PortfolioProject.ViewComponents.Dashboard
{
    public class DashboardTopNavbar: ViewComponent
    {
        public readonly UserManager<WriterUser> _userManager;
        public DashboardTopNavbar(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.ImageUrl = user.ImageUrl;
            return View(user);  
        }
    }
}
