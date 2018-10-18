using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Aviv.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Aviv.DAL
{
    public class AvivDBContext
    {
        public class MyDbContext : DbContext
        {

            public MyDbContext() : base("MySQLConnectionString")
            {
                Database.SetInitializer<MyDbContext>(new AvivDbInitializer());
            }

            public DbSet<Customer> Customers { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<ProductClass> ProductClasses { get; set; }
            public DbSet<Purchase> Purchases { get; set; }
            public DbSet<Quotation> Quotations { get; set; }
            public DbSet<Sale> Sales { get; set; }
            public DbSet<Supplier> Suppliers { get; set; }


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }
}