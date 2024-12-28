using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PortfolioProject.Models;
using System;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    public class WriterUserController : Controller
    {
        private readonly IWriterUserService _writerUserService;
        private  readonly UserManager<WriterUser> _userManager;
        private readonly IPasswordHasher<WriterUser> _passwordHasher;
       
        public WriterUserController(IWriterUserService writerUserService,
            UserManager<WriterUser> userManager,
            IPasswordHasher<WriterUser> passwordHasher)
        {
            _writerUserService = writerUserService; 
            _userManager = userManager;
            _passwordHasher = passwordHasher;
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

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserRegisterViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                WriterUser writerUser = new WriterUser()
                {
                    Name = newUser.Name,
                    SurName = newUser.SurName,
                    UserName = newUser.UserName,
                    Email = newUser.Email,
                    ImageUrl = newUser.ImageUrl,

                };

                IdentityResult result = await _userManager.CreateAsync(writerUser, newUser.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard"); 
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            
            return View(newUser);
        }

        //[HttpGet]
        //public async Task<IActionResult> Update(int id)
        //{
        //    WriterUser user = await _userManager.FindByIdAsync(id.ToString());

        //    if (user != null)
        //    {
        //        UserEditViewModel userEditViewModel = new UserEditViewModel
        //        {
        //            Name = user.Name,
        //            SurName = user.SurName,
        //            UserName = user.UserName,
        //            Email = user.Email,
        //            ImageUrl = user.ImageUrl
        //        };
        //        ViewBag.Id = id;    
        //        return View(userEditViewModel);
        //    }
        //    return View();
        //}
      
    }
}
