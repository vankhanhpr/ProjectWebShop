using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Model;
using ProjectWebShop.Model.discount;

namespace ProjectWebShop.Controllers.discount
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : Controller
    {
        private IDiscountResponsitory m_idiscountResponsitory;
        public DiscountController(IDiscountResponsitory idiscountResponsitory)
        {
            m_idiscountResponsitory = idiscountResponsitory;
        }

        [HttpGet("GetAllDiscount")]
        public DataRespond GetAllDiscount()
        {
            DataRespond data = new DataRespond();
            try
            {
                data.data = m_idiscountResponsitory.GetAllDiscount();
                data.success = true;
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }

        [HttpPost("InsertDiscount")]
        public DataRespond InsertDiscount([FromBody] Discount ds)
        {
            DataRespond  data= new DataRespond();
            try
            {
                m_idiscountResponsitory.CreateEvent(ds);
                data.success = true;
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }

        [HttpPost("UpdateDiscount")]
        public DataRespond UpdateDiscount([FromBody] Discount ds)
        {
            DataRespond data = new DataRespond();
            try
            {
                m_idiscountResponsitory.EditDiscount(ds);
                data.success = true;
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