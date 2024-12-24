using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PortfolioProject.ViewComponents.Dashboard
{
    public class DashboardTopNavbarNotification : ViewComponent
    {
        private readonly IAnnouncementService _announcementService;
        public DashboardTopNavbarNotification(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _announcementService.GetAll().ToList();
            ViewBag.Length=values.Count;
            return View(values);
        }
    }
}
