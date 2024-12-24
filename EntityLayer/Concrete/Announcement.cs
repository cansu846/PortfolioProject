﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Announcement
    {
        [Key]
        public int AnnouncementID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        
        //Duyurunun türünü belirtmek için kullanılır
        public string Status { get; set; }
        public string Content { get; set; }
    }
}
