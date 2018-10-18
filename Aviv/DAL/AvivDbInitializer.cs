using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static Aviv.DAL.AvivDBContext;

namespace Aviv.DAL
{
    public class AvivDbInitializer  : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            // create 3 students to seed the database
            context.Products.Add(new Models.Product { ID = 1, Name = "Mark", ProductClassID = 1, Quantity = 10, Price = 12.5 });
            context.Products.Add(new Models.Product { ID = 2, Name = "Paula", ProductClassID = 1, Quantity = 12, Price = 13.5 });
            context.Products.Add(new Models.Product { ID = 3, Name = "Tom", ProductClassID = 1, Quantity = 14, Price = 14.5 });
            base.Seed(context);
        }
    }
}