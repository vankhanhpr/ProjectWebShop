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
        public DataRespond GetPrHighLights(int pagesize,int page)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.data = _iproductResponsitory.GetProductsHighLights(pagesize,page);
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
        public DataRespond GetProductsMostLikely()
        {
            DataRespond data = new DataRespond();
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
        public DataRespond GetNewProducts()
        {
            DataRespond data = new DataRespond();
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
        public DataRespond GetPrById(int id)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = _iproductResponsitory.GetProductById(id);
                var item = _iproductResponsitory.GetOnlyProduct(id);
                item.totalview = item.totalview + 1;
                _iproductResponsitory.UpdateToTalView(item);
            }
            catch (Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        } 
        [HttpGet("GetPrByLn")]
        public DataRespond GetPrByLn(int lnid)
        {
            DataRespond data = new DataRespond();
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

        //get product with content
        [HttpGet("GetDesPr")]
        public DataRespond GetDesPr()
        {
            DataRespond data = new DataRespond();
            try
            {
                data.data = _iproductResponsitory.GetDesPr();
                data.success = true;
            }
            catch (Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }
    }
}