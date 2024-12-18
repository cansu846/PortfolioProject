using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        private readonly IAboutService _abouService;
        public AboutList(IAboutService aboutService)
        {
            _abouService = aboutService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _abouService.GetAll();
            return View(values);
        }
    }
}
