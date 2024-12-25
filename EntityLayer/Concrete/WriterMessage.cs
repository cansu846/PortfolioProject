﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WriterMessage
    {
        [Key]
        public int WriterMessageID { get; set; }
        //Mail
        public string Sender { get; set; }
        //Mail
        public string Receiver { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
