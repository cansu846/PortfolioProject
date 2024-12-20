using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents.Dashboard
{
    public class DashboardMessages:ViewComponent
    {
        private readonly IUserMessageService _userMessageService;
        public DashboardMessages(IUserMessageService userMessageService)
        {
            _userMessageService = userMessageService;
        }
        public IViewComponentResult Invoke()
        {
            //Bu metodta include cagırılmıştır böylece ilişkili tabloların verilerini kullanabiliriz.
            var values = _userMessageService.GetUserMessageWithUser();

            return View(values);
        }
    }
}
