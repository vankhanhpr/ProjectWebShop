using System;
using System.Collections.Generic;
using System.Globalization;
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
        public DataRespond InsertDiscount([FromBody] DiscountRespond ds)
        {
            DataRespond  data= new DataRespond();
            try
            {
                Discount item = new Discount();
                item.eventname = ds.eventname;
                DateTime stday = DateTime.ParseExact(ds.startday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                item.startday = stday;
                DateTime endday = DateTime.ParseExact(ds.endday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                item.endday = endday;
                item.stt = ds.stt;
                item.percent = ds.percent;
                item.money = ds.money;
                item.note = ds.note;
                item.code = RandomString(10);
                m_idiscountResponsitory.CreateEvent(item);
                data.data = item.code;
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
        [HttpPost("CheckCode")]
        public DataRespond CheckCode([FromBody] CodeRespond modelcode)
        {
            DataRespond data = new DataRespond();
            try
            {
                var ds = m_idiscountResponsitory.GetDisCountByCode(modelcode.code);
                if(ds== null || checkEnable(ds)== false)
                {
                    data.success = false;
                    data.error = "Mã giảm giá không hợp lệ";
                    return data;
                }
                else
                {
                    ds.stt = 1;
                    m_idiscountResponsitory.EditDiscount(ds);
                    data.success = true;
                    data.data = ds;
                }
                data.success = true;
            }
            catch(Exception e)
            {
                data.error = e;
                data.success = false;
            }
            return data;
        }

        public Boolean checkEnable(Discount ds)
        {
            DateTime today = DateTime.Today;
            if (ds.endday < today)
            {
                return false;
            }
            return true;
        }
         //random image 
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTXZW0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}