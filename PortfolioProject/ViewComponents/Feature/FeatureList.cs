using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PortfolioProject.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        IFeatureService _featureService;
        public FeatureList(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _featureService.GetAll();
            return View(values);
        }
    }
}
