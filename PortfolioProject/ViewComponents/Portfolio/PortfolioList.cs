﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents.Portfolio
{
    
    public class PortfolioList:ViewComponent
    {
        private readonly IPortfolioService _portfolioService;
        public PortfolioList(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolioService.GetAll();
            return View(values);  
        }
    }
}
