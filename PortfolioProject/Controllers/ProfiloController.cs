using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    public class ProfiloController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfiloController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.active = "Portfolio";
            //giriş yapmış kullanıcıyı name göre getirir.
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel
            {
                Name = user.Name,
                SurName=user.SurName,
                UserName=user.UserName,
                Email=user.Email,
                ImageUrl=user.ImageUrl
            };

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditViewModel.Image!=null) 
            { 
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(userEditViewModel.Image.FileName);
                //Guid.NewGuid(): Benzersiz bir kimlik (UUID) üretir.
                var imageName =Guid.NewGuid()+extention;
                var saveLocation = Path.Combine(resource, "wwwroot", "userimage", imageName);
                // Yeni bir dosya oluşturur 
                //FileMode.Create: Eğer dosya yoksa oluşturur; varsa mevcut dosyayı üzerine yazar.
                var stream = new FileStream(saveLocation, FileMode.Create);
                //Dosyaya kopyalar
                await userEditViewModel.Image.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }
            user.Name = userEditViewModel.Name;
            user.SurName = userEditViewModel.SurName;
            user.UserName = userEditViewModel.UserName;
            user.Email = userEditViewModel.Email;
            //giriş yapmış kullanıcıyı name göre getirir.
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Default");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }
            }
            return View();
        }
    }
}
