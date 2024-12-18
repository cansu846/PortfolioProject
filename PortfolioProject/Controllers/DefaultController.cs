using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Header()
        {
            return PartialView();
        }

        public PartialViewResult Head()
        {
            return PartialView();
        }
    }
}
