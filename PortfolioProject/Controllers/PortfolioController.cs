using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }
        public IActionResult Index()
        {
            var values = _portfolioService.GetAll();    
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            _portfolioService.Add(portfolio);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeletePortfolio(int id)
        {
            var isExsist = _portfolioService.GetByID(id);
            if (isExsist != null)
            {

                _portfolioService.delete(isExsist);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var isExsist = _portfolioService.GetByID(id);
            if (isExsist != null)
            {

                return View(isExsist);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            _portfolioService.update(portfolio);
            return RedirectToAction("Index");
        }

    }
}
