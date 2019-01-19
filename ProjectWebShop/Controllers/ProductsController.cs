using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Model;
using WebApiMyShop.Data;

namespace ProjectWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController:Controller
    {
        private readonly IProductResponsitory _iproductResponsitory;
        public ProductsController(IProductResponsitory iproductResponsitory)
        {
            this._iproductResponsitory = iproductResponsitory;
        }
        [HttpGet]
        public IEnumerable<Products> GetAll()
        {
            IEnumerable<Products> list= _iproductResponsitory.GetAllWidthProducts();
            return list;
        }
    }
}