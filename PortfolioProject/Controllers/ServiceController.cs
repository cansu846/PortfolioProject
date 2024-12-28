using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public IActionResult Index()
        {
            ViewBag.active = "Service";
            var values = _serviceService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service newService)
        {
            _serviceService.Add(newService);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteService(int id)
        {
            var isExsist = _serviceService.GetByID(id);
            if (isExsist != null)
            {
                _serviceService.delete(isExsist);
            }
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var isExsist = _serviceService.GetByID(id);
            return View(isExsist);
        }

        [HttpPost]
        public IActionResult EditService(Service newService)
        {
            _serviceService.update(newService);
            return RedirectToAction("Index");
        }
    }
}
