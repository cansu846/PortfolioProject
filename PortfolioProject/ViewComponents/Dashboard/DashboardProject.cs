using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PortfolioProject.ViewComponents.Dashboard
{
    public class DashboardProject:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}
