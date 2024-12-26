using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
