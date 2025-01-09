using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class TestimonialController:Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        public IActionResult Index()
        {
            ViewBag.active = "Testimonial";
            var values = _testimonialService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial newTestimonial)
        {
            _testimonialService.Add(newTestimonial);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteTestimonial(int id)
        {
            var isExsist = _testimonialService.GetByID(id);
            if (isExsist != null)
            {
                _testimonialService.delete(isExsist);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var isExsist = _testimonialService.GetByID(id);
            return View(isExsist);
        }

        [HttpPost]
        public IActionResult EditTestimonial(Testimonial newTestimonial)
        {
            _testimonialService.update(newTestimonial);
            return RedirectToAction("Index");
        }
    }
}
