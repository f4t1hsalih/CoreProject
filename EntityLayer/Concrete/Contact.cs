﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
