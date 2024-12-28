using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PortfolioProject.Controllers
{
    public class MessageController:Controller
    {
        private readonly IUserMessageService _userMessageService;
        public MessageController(IUserMessageService userMessageService)
        {
            _userMessageService = userMessageService;
        }
        public IActionResult Index()
        {
           
            var values = _userMessageService.GetUserMessageWithUser();
            
            return View(values);
        }
    }
}
