using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.unit;
using ProjectWebShop.Model;

namespace ProjectWebShop.Controllers.unit
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : Controller
    {
        private IProvinceResponsitory m_provinceResponsitory;
        public ProvinceController(IProvinceResponsitory iprovinceResponsitory)
        {
            m_provinceResponsitory = iprovinceResponsitory;
        }

        [HttpGet("GetProvince")]
        public DataRespond GetProvince()
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_provinceResponsitory.getAllProvince();
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