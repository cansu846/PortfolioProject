using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        IExperienceService _experienceService;
        public ExperienceList(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _experienceService.GetAll();
            return View(values);
        }
    }
}
