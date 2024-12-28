using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PortfolioProject.ViewComponents.DashboardHeader
{
    public class DashboardHeaderComponent : ViewComponent
    {
        IWriterUserService writerUser = new WriterUserManager(new EfWriterUserDal());
        public IViewComponentResult Invoke()
        {
            //oluşturdugum context sınıfı
            Context context = new Context();
            ViewBag.totalProject = context.Portfolios.Count();
            ViewBag.totalUser = writerUser.GetAll().Count();
            ViewBag.totalMessage = context.Messages.Count();
            ViewBag.totalReferance = context.Testimonials.Count();

            return View();
        }
    }
}
