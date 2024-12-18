using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Bu sınıf referans görevi görmektedir.
    public class Testimonial
    {
        [Key] // Primary key olduğunu belirtir
        public int TestimonialID { get; set; }

        //Referansı yapan kişinin adı
        public string ClientName { get; set; }

        //kişinin çalıştıgı iş yeri
        public string Company { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
