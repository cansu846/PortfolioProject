using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult SideNavbarPartial()
        {
            return PartialView();
        }
    }
}
