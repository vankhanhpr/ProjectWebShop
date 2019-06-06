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
        //for admin
        dynamic GetAllWidthProducts();
        dynamic GetProductById(int id);
        void SaveProduct(Products product);
        void DeleteProduct(int id);
        void UpdateProduct(Products product);
        dynamic GetProductByLinePr(int id);
        Products GetaProductById(int id);

        //for user
        dynamic GetProuctsHighLights();
        dynamic GetProcutsMostLikely();
        dynamic GetNewProducts();
    }
}
