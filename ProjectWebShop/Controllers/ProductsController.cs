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
        public void SaveProduct([FromBody]Products pdt)
        {
            _iproductResponsitory.SaveProduct(pdt);
        }
        [HttpPost("UpdateProduct")]
        public object UpdateProduct([FromBody]Products pdt)
        {
            if (pdt == null)
            {
                return Ok(new { data = "Error" }); ;
            }
            else
            {
                _iproductResponsitory.UpdateProduct(pdt);
                return Ok(new { data = "Success" });
            }
        }
        //https://localhost:44337/api/products/DeleteProduct?id=1
        [HttpPost("DeleteProduct")]
        public object DeleteProduct(int id)
        {
            try
            {
                _iproductResponsitory.DeleteProduct(id);
                return Ok(new { data = "Success" });
            }
            catch(Exception e)
            {
               return Ok(new { data = "Error" });
            }
        }
        //https://localhost:44337/api/products/GetByuLine?id=2
        [HttpPost("GetByuLine")]
        public dynamic GetByuLine(int id)
        {
            return _iproductResponsitory.GetProductByLinePr(id);
        }
    }
}