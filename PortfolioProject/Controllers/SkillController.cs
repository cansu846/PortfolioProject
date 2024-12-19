using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;
        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }
        public IActionResult Index()
        {
            var values = _skillService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill newSkill)
        {
            _skillService.Add(newSkill);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteSkill(int id)
        {
            var isExsist = _skillService.GetByID(id);
            if (isExsist != null)
            {
                _skillService.delete(isExsist);
            }
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var isExsist = _skillService.GetByID(id);
            return View(isExsist);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill newSkill)
        {
            _skillService.update(newSkill);
            return RedirectToAction("Index");
        }
    }
}
