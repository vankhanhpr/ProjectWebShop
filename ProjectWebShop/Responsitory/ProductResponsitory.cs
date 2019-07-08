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
        public dynamic GetProductByLinePr(int id)
        {
            //var ab = context.Products
            //  .Join(context.LineProducts, a => a.lineprid, b => b.lineprid, (a, b) => new { a }).Where(p => p.a.lineprid == id);
            //var ab = context.Products
            //  .Join(context.LineProducts, a => a.lineprid, b => b.lineprid, (a, b) => new { a }).Where(p => p.a.lineprid == id);
            //return ab.ToList();
            try
            {
                return context.Products
                               .Where(p => p.lineprid == id).ToList();
            }
            catch (Exception e)
            {
                return null;
            }


        }
        public dynamic GetProductById(int id)
        {
            var pdt = context.Products.Where(x => x.prid == id).Select(product => new
            {
                product,
                images = context.ImageProducts.Where(image => image.prid == product.prid).ToList()
            }).FirstOrDefault();
            return pdt;
        }
        public Products GetaProductById(int id)
        {
            return context.Products
                .Where(p => p.prid == id).FirstOrDefault();
        }
        public void SaveProduct(Products product)
        {
            context.Entry(product).State = EntityState.Added;
            context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            Products product = GetaProductById(id);
            productEntity.Remove(product);
            context.SaveChanges();
        }
        public void UpdateProduct(Products product)
        {
            context.Update(product);
            context.SaveChanges();
        }


        //for user
        public dynamic GetProductsHighLights(int pagesize,int page)
        {
            var prd = context.Products.Where(x => x.highlight == 1).Select(product => new
            {
                product,
                images = context.ImageProducts.Where(image => image.prid == product.prid).ToList()
            }).Skip((page-1)*pagesize).Take(pagesize);
            var data = new { prd = prd, total = GetTotaHlPr() };
            return data;
        }

        public dynamic GetProcutsMostLikely()
        {
            var data = context.Products.OrderBy(x => x.totallike).Select(product => new
            {
                product,
                images = context.ImageProducts.Where(image => image.prid == product.prid).ToList()
            }).Take(8);
            return data;
        }

        public dynamic GetNewProducts()
        {
            var data = context.Products.OrderBy(x => x.createday).Select(product => new
            {
                product,
                images = context.ImageProducts.Where(image => image.prid == product.prid).ToList()
            });
            return data;
        }

        public void UpdateToTalView(Products prd)
        {
            context.Update(prd);
            context.SaveChanges();
        }

        public Products GetOnlyProduct(int prid)
        {
            return context.Products.Where(x => x.prid == prid).FirstOrDefault();
        }

        public dynamic GetDesPr()
        {
            var data = context.Products.OrderBy(x => x.createday).Select(product => new
            {
                product,
                des = context.Describeproducts.Where(d => d.prid == product.prid).FirstOrDefault()
            }).Take(4);
            return data;
        }

        public int GetTotaHlPr()
        {
            int total = context.Products.Where(x=>x.highlight==1).Count();
            if( total % 3 > 0)
            {
                total = (total/3) + 1;
            }
            else
            {
                total = total / 3;
            }
            return total;
        }
    }
}
