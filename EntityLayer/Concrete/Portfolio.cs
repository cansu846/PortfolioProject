using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Projeleri sunmak için kullanılır
    public class Portfolio
    {
        [Key] // Primary key olduğunu belirtir
        public int PortfolioID { get; set; }

        //proje ismi
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
