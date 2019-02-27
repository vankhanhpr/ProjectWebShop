using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model;

namespace ProjectWebShop.Interface.product
{
    public interface IProductResponsitory:IResponsitory<Products>
    {
        IEnumerable<Products> GetAllWidthProducts();
        Products GetProductById(string id);
        void SaveProduct(Products product);
        void DeleteProduct(string id);
        void UpdateProduct(Products product);
        dynamic GetProductByLinePr(int id);
    }
}
