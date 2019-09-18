﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

    }
}
