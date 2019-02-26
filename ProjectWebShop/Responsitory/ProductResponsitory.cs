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
        public dynamic GetProductByLinePr(int id)
        {
           var ab =  context.Products
                .Join(context.LineProducts, a => a.lineprid, b => b.lineprid , (a, b) => new {a}).Where(p=>p.a.lineprid==id);

            return ab.ToList();
        }
        public Products GetProductById(int id)
        {
            return context.Products
                .Where(p => p.prid == id)
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
            context.Update(product);
            context.SaveChanges();
        }

        //public IEnumerable<Products> IProductResponsitory.GetProductByLinePr(string id)
        //{
        //    var ab = context.Products
        //         .Join(context.LineProducts, a => a.lineprid, b => b.lineprid, (a, b) => new { a });

        //    return ab.toI;
        //}
    }
}
