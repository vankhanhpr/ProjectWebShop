using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Model;

namespace ProjectWebShop.Controllers
{
    [Route("api/productuser")]
    [ApiController]
    public class ProductUserController : Controller
    {
        private readonly IProductResponsitory _iproductResponsitory;
        private readonly IImageProductResponsitory _iimageProductResponsitory;
        public ProductUserController(IProductResponsitory iproductResponsitory, IImageProductResponsitory iimageProductResponsitory)
        {
            this._iproductResponsitory = iproductResponsitory;
            this._iimageProductResponsitory = iimageProductResponsitory;
        }
        [HttpGet("getProductsHighLights")]
        public DataRespont GetPrHighLights()
        {
            DataRespont data = new DataRespont();
            try
            {
                data.data = _iproductResponsitory.GetProuctsHighLights();
                data.success = true;
            }
            catch (Exception e)
            {
                data.success = false;
                data.data = e;
            }
            return data;
        }
        [HttpGet("GetProductsMostLikely")]
        public DataRespont GetProductsMostLikely()
        {
            DataRespont data = new DataRespont();
            try
            {
                data.data = _iproductResponsitory.GetProcutsMostLikely();
                data.success = true;
            }
            catch (Exception e)
            {
                data.success = false;
                data.data = e;
            }
            return data;
        }
        [HttpGet("GetNewProducts")]
        public DataRespont GetNewProducts()
        {
            DataRespont data = new DataRespont();
            try
            {
                data.data = _iproductResponsitory.GetNewProducts();
                data.success = true;
            }
            catch (Exception e)
            {
                data.success = false;
                data.data = e;
            }
            return data;
        }

        [HttpGet("GetproductbyId")]
        public DataRespont GetPrById(int id)
        {
            DataRespont data = new DataRespont();
            try
            {
                data.success = true;
                data.data = _iproductResponsitory.GetProductById(id);
            }
            catch (Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        } 
        [HttpGet("GetPrByLn")]
        public DataRespont GetPrByLn(int lnid)
        {
            DataRespont data = new DataRespont();
            try
            {
                data.success = true;
                data.data = _iproductResponsitory.GetProductByLinePr(lnid);
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }

            return data;
        }
    }
}