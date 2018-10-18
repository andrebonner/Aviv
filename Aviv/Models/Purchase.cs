using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aviv.Models
{
    public class Purchase
    {
        public int ID { get; set; }
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
        public double Quantity { get; set; }
        public Double Total { get; set; }
        public String Notes { get; set; }
        public DateTime PurchaseDate { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual Product Product { get; set; }
    }
}