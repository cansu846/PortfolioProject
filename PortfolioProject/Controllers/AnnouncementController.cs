using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }
        public IActionResult Index()
        {
            var values = _announcementService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var values = _announcementService.GetByID(id);
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Announcement announcement)
        {
            _announcementService.Add(announcement);
            return RedirectToAction("Index","Announcement");
        }
    }
}
