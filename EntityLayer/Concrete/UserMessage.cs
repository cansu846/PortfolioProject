using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kullanılmayacak.
namespace EntityLayer.Concrete
{
    public class UserMessage
    {
        [Key] // Primary key olduğunu belirtir
        public int UserMessageID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        //Mesajın okunup okunmadı bilgisini tutar
        public bool Status { get; set; }
        public int UserID { get; set; } // Foreign key
        public User User { get; set; } // Navigation property
    }
}
