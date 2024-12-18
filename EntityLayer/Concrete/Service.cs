using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key] // Primary key olduğunu belirtir
        public int ServiceID { get; set; }
        public string Header { get; set; }
        public string ImageUrl { get; set; }

    }
}
