using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PortfolioProject.ViewComponents.DashboardHeader
{
    public class DashboardHeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //oluşturdugum context sınıfı
            Context context = new Context();
            ViewBag.totalProject = context.Portfolios.Count();
            ViewBag.totalCompany = context.Experiences.Count();
            ViewBag.totalMessage = context.Messages.Count();
            ViewBag.totalReferance = context.Testimonials.Count();

            return View();
        }
    }
}
