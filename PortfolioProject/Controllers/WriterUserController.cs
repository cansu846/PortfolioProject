using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace PortfolioProject.Controllers
{
    public class WriterUserController : Controller
    {
        private readonly IWriterUserService _writerUserService;
        public WriterUserController(IWriterUserService writerUserService)
        {
            _writerUserService = writerUserService; 
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(_writerUserService.GetAll());
            Console.WriteLine(values);
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddUser(WriterUser p)
        {
            _writerUserService.Add(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

    }
}
