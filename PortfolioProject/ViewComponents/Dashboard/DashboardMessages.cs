using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents.Dashboard
{
    public class DashboardMessages:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
