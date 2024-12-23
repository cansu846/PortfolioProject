using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Models;

namespace PortfolioProject.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            return View();
        }

        [HttpGet]   
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterViewModel userRegisterViewModel)
        {
            //Alınan bilgiler AspNetUsers tablosuna kaydedilir
            return View();
        }
    }
}
