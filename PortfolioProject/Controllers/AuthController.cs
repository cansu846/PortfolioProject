using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PortfolioProject.Models;
using System;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public AuthController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

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
        public async Task<IActionResult> Register(UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                //Alınan bilgiler AspNetUsers tablosuna kaydedilir
                //WriterUser adında bir tablo yoktur. Bu sınıf AspNetUsers a ek özellik saglaması için oluşturulmuştur.
                WriterUser newUser = new WriterUser
                {
                    Name = userRegisterViewModel.Name,
                    SurName = userRegisterViewModel.SurName,
                    UserName = userRegisterViewModel.UserName,
                    ImageUrl = userRegisterViewModel.ImageUrl,
                    Email = userRegisterViewModel.Email,
                };

                var result = await _userManager.CreateAsync(newUser, userRegisterViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Auth", "Login");
                }

                else
                { 
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                   
                }
            }

            return View();
        }
    }
}
