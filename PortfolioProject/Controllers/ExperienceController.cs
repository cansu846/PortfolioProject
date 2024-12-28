using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class ExperienceController:Controller
    {
        private readonly IExperienceService _experienceService;
        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        public IActionResult Index()
        {
            ViewBag.active = "Experience";
            var values = _experienceService.GetAll();
            return View(values);  
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult AddExperience(Experience experience)
        {
            _experienceService.Add(experience);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteExperience(int id)
        {
            var isExsist = _experienceService.GetByID(id);
            if (isExsist != null) { 

                _experienceService.delete(isExsist);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var isExsist = _experienceService.GetByID(id);
            if (isExsist != null)
            {

                return View(isExsist);  
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            _experienceService.update(experience);
            return RedirectToAction("Index");
        }

    }
}
