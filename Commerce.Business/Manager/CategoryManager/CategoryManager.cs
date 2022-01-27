using Commerce.Data.ORM.Context;
using Commerce.Data.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commerce.Business.Manager.CategoryManager
{
    public class CategoryManager
    {
        
        //List
        public static List<Category> GetCategories()
        {
            Context context = new Context();
            List<Category> categories = context.Categories.Where(x => x.IsDeleted == false).ToList();
            return categories;
        }
        //getByid
        public static Category GetCategory(int id)
        {
            Context context = new Context();
            Category category =context.Categories.FirstOrDefault(x=> x.Id == id && x.IsDeleted==false);
            return category;
        }
        //Add
        public static void Add(Category category)
        {
            Context context = new Context();
            category.IsDeleted = false;
            category.AddDate = DateTime.Now;

            context.Categories.Add(category);
            context.SaveChanges();
        }
        public static void Delete(int id)
        {
            Context context = new Context();
            Category category = context.Categories.FirstOrDefault(x => x.IsDeleted == false);
            category.IsDeleted = true;
            context.SaveChanges();
        }


    }
}
