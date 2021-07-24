using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public class ENV
    {
        public const string ImagePath = @"\images\products\";
        public const string SessionCart = "ShoppingCartSession";
       
        public static string AdminRole = "Admin";
        public static string CustomerRole = "Customer";

        public const string EmailAdmin = "@gmail.com";

    }
}
