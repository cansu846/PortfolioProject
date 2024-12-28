using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;

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
            ViewBag.active = "Portfolio";
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
            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult result = validator.Validate(portfolio);
            if (result.IsValid)
            {
                _portfolioService.Add(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
                return View();
            }
           
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
