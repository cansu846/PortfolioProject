using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        public IActionResult Index()
        {
            ViewBag.activePage = "About";
            var values = _aboutService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAbout(About newAbout)
        {
            _aboutService.Add(newAbout);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteAbout(int id)
        {
            var isExsist = _aboutService.GetByID(id);
            if (isExsist != null)
            {
                _aboutService.delete(isExsist);
            }
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var isExsist = _aboutService.GetByID(id);
            return View(isExsist);
        }

        [HttpPost]
        public IActionResult EditAbout(About newAbout)
        {
            _aboutService.update(newAbout);
            return RedirectToAction("Index");
        }
    }
}
