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
    public class ProductResponsitory : Responsitory<Products>, IProductResponsitory
    {
        private DbSet<Products> productEntity;
        public ProductResponsitory(MyDBContext context) : base(context)
        {
            productEntity = context.Set<Products>();
        }
        public dynamic GetAllWidthProducts()
        {
            //var pdt = context.Products
            //    .Join(context.ImageProducts, product => product.prid,
            //    images => images.prid, (product, images) => new { product, images });

            var pdt = context.Products.Select(product => new
            {
                product,
                images = context.ImageProducts.Where(image => image.prid == product.prid).ToList()
            });
            return pdt.ToList();
        }
<<<<<<< HEAD
        public Products GetProductById(string id)
=======
        public dynamic GetProductByLinePr(int id)
        {
            var ab = context.Products
                 .Join(context.LineProducts, a => a.lineprid, b => b.lineprid, (a, b) => new { a }).Where(p => p.a.lineprid == id);

            return ab.ToList();
        }
        public Products GetProductById(int id)
>>>>>>> 812a570574fd07dafcc527858df96b137123a2d6
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
        public void DeleteProduct(string id)
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
    }
}
