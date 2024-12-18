using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key] // Primary key olduğunu belirtir
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        //Mesajın okunup okunmadı bilgisini tutar
        public bool Status { get; set; }
    }
}
