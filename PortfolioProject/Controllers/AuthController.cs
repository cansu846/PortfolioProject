using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PortfolioProject.Models;
using System;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        private readonly SignInManager<WriterUser> _signInManager;
        public AuthController(UserManager<WriterUser> userManager, SignInManager<WriterUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login","Auth");
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid) 
            {
                var result = await _signInManager.PasswordSignInAsync(userLoginViewModel.UserName, userLoginViewModel.Password,true,true);
                if (result.Succeeded)
                {
                   return RedirectToAction("Index", "Default");
                }
                else
                {
                    ModelState.AddModelError("", "Password or UserName faulty");
                }
            }
            return View();
        }
        //123456.Aa*

        [HttpGet]   
        public IActionResult Register()
        {
            return View(new UserRegisterViewModel());
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
                if (userRegisterViewModel.Password == userRegisterViewModel.ConfirmPassword) {
                    var result = await _userManager.CreateAsync(newUser, userRegisterViewModel.Password);
                    if (result.Succeeded)
                    {
                        //Auth controller içindeki Login Methoduna yönlendirir
                        return RedirectToAction("Login", "Auth");
                    }

                    else
                    { 
                        foreach(var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                   
                    }
                }
            }

            return View(userRegisterViewModel);
        }
    }
}
