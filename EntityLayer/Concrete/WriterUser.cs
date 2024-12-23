using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Mesaj yazan kullanıcıları tanımlar,
    //IdentityUser AspNetUsers tablosunu ifade eder.
    //Veri tabanında WriterUser adında bir tablo oluşmaz sadece IdentityUser tablsuna ek özellikler eklenir.
    public class WriterUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ImageUrl { get; set; }


    }
}
