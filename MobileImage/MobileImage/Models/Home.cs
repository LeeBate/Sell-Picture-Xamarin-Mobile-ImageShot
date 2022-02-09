﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MobileImage.Models
{
    class Home
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public Uri Url { get; set; }
    }
}