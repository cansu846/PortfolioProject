using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioProject.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetBySearch(string query)
        {
            if (query.Trim() == "" || query==null) { 
                return RedirectToAction("Index","Dashboard");
            }
            var editQuery = query.Trim().ToLower();
            query = editQuery;
            using var context = new Context();

            var users = context.Set<WriterUser>().ToList();

            var filtredUsers = users.Where(u => u.UserName.ToLower().Contains(query) || u.Name.ToLower().Contains(query)).ToList();

            var projects = context.Portfolios.Where(p => p.Name.ToLower().Contains(query)).ToList();

            var services = context.Services.Where(p => p.Header.ToLower().Contains(query)).ToList();
            var skills = context.Skills.Where(s => s.Header.ToLower().Contains(query)).ToList();
            
            if(filtredUsers.Count==0 && projects.Count==0 && services.Count==0 && skills.Count==0)
                return RedirectToAction("Index", "Dashboard");

            return View(new ListForSearchViewModel(){
                FiltredUsers=filtredUsers,
                Projects= projects,
                Services= services,
                Skills= skills,
            });
        }
    }
}
