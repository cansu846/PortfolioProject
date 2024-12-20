using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
        //public PartialViewResult HeaderPartial()
        //{

        //    return PartialView();   
        //}
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
    }
}
