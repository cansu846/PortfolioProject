using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key] // Primary key olduğunu belirtir
        public int AboutID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }

        public string Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }

        //resimler dosya yolu olarak tutulur
        public string ImageUrl { get; set; }


    }
}
