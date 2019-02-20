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
        public ProductResponsitory(MyDBContext context):base (context)
        {
            
        }
        public IEnumerable<Products> GetAllWidthProducts()
        {
            return context.Products.ToList();
        }
        public Products GetProductById(int id)
        {
            return context.Products
                .Where(p=> p.id == id)
                .FirstOrDefault();
        }
    }
}
