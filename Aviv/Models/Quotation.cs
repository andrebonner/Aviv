using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aviv.Models
{
    public class Quotation
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public double Quantity { get; set; }
        public Double Total { get; set; }
        public String Notes { get; set; }
        public DateTime QuoteDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}