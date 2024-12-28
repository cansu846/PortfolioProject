using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace PortfolioProject.Models
{
    public class ListForSearchViewModel
    {
        public List<WriterUser> FiltredUsers { get; set; }
        public List<Portfolio> Projects { get; set; }
        public List<Service> Services { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
