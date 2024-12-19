using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Header()
        {
            return PartialView();
        }

        public PartialViewResult Head()
        {
            return PartialView();
        }



        [HttpGet]
        public PartialViewResult SendMessage()
        {
           
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Message m)
        {
            IMessageService _messageService = new MessageManager(new EfMessageDal());
            m.Date = System.DateTime.Now;
            m.Status = true;
            _messageService.Add(m);

            return Redirect("/Default/Index/");
        }

   
    }
}
