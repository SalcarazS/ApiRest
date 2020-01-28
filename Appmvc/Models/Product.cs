using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appmvc.Models
{
    public class Product
    {
        public int id { get; set; }
        public string description { get; set; }
        public float price { get; set; }
    }
}