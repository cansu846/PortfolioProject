using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;
        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public IActionResult Index()
        {
            ViewBag.active = "Feature";
            var values = _featureService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFeature(Feature newFeature)
        {
            _featureService.Add(newFeature);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteFeature(int id)
        {
            var isExsist = _featureService.GetByID(id);
            if (isExsist != null)
            {
                _featureService.delete(isExsist);
            }
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            var isExsist = _featureService.GetByID(id);
            return View(isExsist);
        }

        [HttpPost]
        public IActionResult EditFeature(Feature newFeature)
        {
            _featureService.update(newFeature);
            return RedirectToAction("Index");
        }
    }
}
