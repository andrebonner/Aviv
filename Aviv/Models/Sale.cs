﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aviv.Models
{
    public class Sale
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public double Quantity { get; set; }
        public double Total { get; set; }
        public String Notes { get; set; }
        public DateTime SaleDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}