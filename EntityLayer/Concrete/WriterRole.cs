using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //IdentityRole AspNetRoles tablosunu ifade eder.
    //Veri tabanında WriteRole adında bir tablo oluşmaz sadece IdentityRole tablsuna ek özellikler eklenir.
    public class WriterRole:IdentityRole<int>
    {

    }
}
