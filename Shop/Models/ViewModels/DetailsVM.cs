﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.ViewModels
{
    public class DetailsVM
    {
        public Product Product { get; set; }

        public bool InCart { get; set; }
        public DetailsVM()
        {
            Product = new Product();
        }
    }
}
