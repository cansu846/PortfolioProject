using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace PortfolioProject.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialList(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.GetAll();
            return View(values);
        }
    }
}