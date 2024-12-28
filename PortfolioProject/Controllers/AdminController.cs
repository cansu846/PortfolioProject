using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly IWriterUserService _writerUserService;
        public AdminController(IWriterUserService writerUserService)
        {
            _writerUserService = writerUserService;
        }
        public IActionResult Index()
        {
            ViewBag.active = "Admin";
            var values = _writerUserService.GetAll();
            return View(values);
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        //public PartialViewResult TopNavbarPartial()
        //{
        //    return PartialView();
        //}
        //public PartialViewResult SideNavbarPartial()
        //{
        //    return PartialView();
        //}
        //public PartialViewResult HeaderPartial()
        //{
        //    return PartialView();   
        //}

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }

        
    }
}
