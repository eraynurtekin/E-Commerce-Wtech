using Commerce.Data.ORM.Context;
using Commerce.Data.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commerce.Business.Manager.ProductManager
{
    public class ProductManager
    {
        //List
        public static List<Product> GetProducts()
        {
            Context context = new Context();
            List<Product> products = context.Products.Where(x => x.IsDeleted == false).ToList();
            return products;
        }

        //Add
        public static void Add(Product product)
        {
            Context context = new Context();

            product.IsDeleted = false;
            product.AddDate = DateTime.Now; 

            context.Products.Add(product);
            context.SaveChanges();
        }
        public static void Delete(int id)
        {
            Context context = new Context();
            Product product = context.Products.FirstOrDefault(x=>x.Id == id);
            product.IsDeleted = true;

            context.SaveChanges();

        }
    }
}
