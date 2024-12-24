using BusinessLayer.Abstract;
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
    }
}
