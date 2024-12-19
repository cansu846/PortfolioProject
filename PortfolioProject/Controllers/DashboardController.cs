using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public PartialViewResult ScriptPartial() {
        //    return PartialView();
        //}
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult SideNavbarPartial() { 
            return PartialView();
        }

        public PartialViewResult TopNavbarPartial() { 
            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();   
        }
    }
}
