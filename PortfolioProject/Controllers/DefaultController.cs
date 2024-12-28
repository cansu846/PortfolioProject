using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    
    [Authorize]
    public class DefaultController : Controller
    {
        //Duyuruları görüntülemek için kullanılır
        public IActionResult Index()
        {
            ViewBag.active = "Default";
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
        public PartialViewResult SendMessagePartial()
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

            //aşağdakide kullanılabilir
            //return Redirect("/Default/Index/")
            return RedirectToAction("Index","Default");
        }

        [HttpPost]
        public IActionResult SendUserMessage(UserMessage m)
        {
            IUserMessageService _messageService = new UserMessageManager(new EfUserMessageDal());
            m.Date = System.DateTime.Now;
            m.Status = true;
            _messageService.Add(m);

            //aşağdakide kullanılabilir
            //return Redirect("/Default/Index/")
            return RedirectToAction("Index", "Default");
        }


    }
}
