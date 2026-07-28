using QuickBite.Context;
using QuickBite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBite.Services
{
    public class ProductService
    {
        public List<Product> GetAll()
        {
            using var context = new QuickBiteContext();
            return context.Products.OrderBy(p => p.NameProduct).ToList();
        }
        public List<Product> GetProductsByCategory(ProductCategory category)
        {
            using var context = new QuickBiteContext();
            return context.Products
                .Where(p => p.Category == category)
                .OrderBy(p => p.NameProduct)
                .ToList();
        }

        public void Add(Product product)
        {
            using var context = new QuickBiteContext();
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Update(Product product)
        {
            using var context = new QuickBiteContext();
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new QuickBiteContext();
            var product = context.Products.Find(id);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
