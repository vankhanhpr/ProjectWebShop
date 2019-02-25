using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Model;
using WebApiMyShop.Data;

namespace ProjectWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductResponsitory _iproductResponsitory;
        public ProductsController(IProductResponsitory iproductResponsitory)
        {
            this._iproductResponsitory = iproductResponsitory;
        }
        [HttpGet("GetAllProduct")]
        public IEnumerable<Products> GetAll()
        {
            return _iproductResponsitory.GetAllWidthProducts();
        }
        [HttpPost("InsertProduct")]
        public void UpdateProducte([FromBody]Products pdt)
        {
            _iproductResponsitory.SaveProduct(pdt);
        }
    }
}