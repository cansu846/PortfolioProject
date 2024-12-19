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
            return View();
        }
    }
}
