using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aviv.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProductClassID { get; set; }
        public double Quantity { get; set; }
        public Double Price { get; set; }

        public virtual ProductClass ProductClass { get; set; }
    }
}