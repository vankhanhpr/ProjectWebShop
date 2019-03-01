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
<<<<<<< HEAD
        dynamic GetAllWidthProducts();
        Products GetProductById(int id);
=======
        IEnumerable<Products> GetAllWidthProducts();
        Products GetProductById(string id);
>>>>>>> 42c3344834ac292481d7bbcabfe0ee39375a6200
        void SaveProduct(Products product);
        void DeleteProduct(string id);
        void UpdateProduct(Products product);
        dynamic GetProductByLinePr(int id);
    }
}
