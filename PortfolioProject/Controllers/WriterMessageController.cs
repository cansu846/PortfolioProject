using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class WriterMessageController : Controller
    {
        private readonly IWriterMessageService _writerMessageService;

        public WriterMessageController(IWriterMessageService writerMessageService)
        {
            _writerMessageService = writerMessageService;
        }
        public IActionResult Index()
        {
            var values = _writerMessageService.GetAll();
            return View(values);  
        }
        public IActionResult ViewDetail(int id)
        {
            return View();
        }
    }
}
