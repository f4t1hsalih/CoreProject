﻿using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int ID { get; set; }
        public string Header { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
