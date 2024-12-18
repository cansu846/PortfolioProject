using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key] // Primary key olduğunu belirtir
        public int ContactID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
