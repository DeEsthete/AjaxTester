using AjacTester.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjacTester.Data
{
    public class ProductContextInitializer : CreateDatabaseIfNotExists<ProductContext>
    {
        protected override void Seed(ProductContext db)
        {
            Product product = new Product { Id = 1, Name = "Хлеб", Price = 70 };
            Product product1 = new Product { Id = 2, Name = "Молоко", Price = 220 };
            Product product2 = new Product { Id = 3, Name = "Шоколад", Price = 400 };
            db.Products.Add(product);
            db.Products.Add(product1);
            db.Products.Add(product2);
            db.SaveChanges();
        }
    }
}