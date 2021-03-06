﻿using System;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Model;

namespace ProjectWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductResponsitory _iproductResponsitory;
        private readonly IImageProductResponsitory _iimageProductResponsitory;
        public ProductsController(IProductResponsitory iproductResponsitory, IImageProductResponsitory iimageProductResponsitory)
        {
            this._iproductResponsitory = iproductResponsitory;
            this._iimageProductResponsitory = iimageProductResponsitory;
        }
        [HttpGet("GetAllProduct")]
        public dynamic GetAll()
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
                _iimageProductResponsitory.DeleteImgByPr(id);
                _iproductResponsitory.DeleteProduct(id);
                return Ok(new { data = "Success" });
            }
            catch(Exception e)
            {
               return Ok(new { data = "Error" });
            }
        }
        //https://localhost:44337/api/products/GetByuLine?id=2
        [HttpGet("GetByLine")]
        public dynamic GetByLine(int id)
        {
            return _iproductResponsitory.GetProductByLinePr(id);
        }
        [HttpPost("GetPrById")]
        [HttpGet("GetPrById")]
        public dynamic GetProductByID(int id)
        {
            return _iproductResponsitory.GetProductById(id);
        }
        
    }
}