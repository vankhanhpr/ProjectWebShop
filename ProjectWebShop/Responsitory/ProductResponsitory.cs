using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Model;
using WebApiMyShop.Data;

namespace ProjectWebShop.Responsitory
{
    public class ProductResponsitory : Responsitory<Products>,IProductResponsitory
    {
        private DbSet<Products> productEntity;
        public ProductResponsitory(MyDBContext context):base (context)
        {
            productEntity = context.Set<Products>();
        }
        public IEnumerable<Products> GetAllWidthProducts()
        {
            return context.Products.ToList();
        }
        public Products GetProductById(int id)
        {
            return context.Products
                .Where(p=> p.prid == id)
                .FirstOrDefault();
        }
        public void SaveProduct(Products product)
        {
            context.Entry(product).State = EntityState.Added;
            context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            Products product = GetProductById(id);
            productEntity.Remove(product);
            context.SaveChanges();
        }
        public void UpdateProduct(Products product)
        {
            context.SaveChanges();
        }
    }
}
