using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key] // Primary key olduğunu belirtir
        public int SocialMediaID { get; set; }
        public string Name { get; set; }

        //Yönlendirilecek sayfanın url bilgisini tutar
        public string Url { get; set; }

        //İcona ait url bilgisini tutar
        public string icon { get; set; }
        public bool Status { get; set; }
    }
}
