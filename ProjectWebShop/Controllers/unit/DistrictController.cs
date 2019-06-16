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
    public class DistrictController : Controller
    {
        private IDistrictResponsitory m_IDistrictResponsitory;
        public DistrictController(IDistrictResponsitory iDistrictResponsitory)
        {
            m_IDistrictResponsitory = iDistrictResponsitory;
        }
        [HttpGet("GetDtByProvince")]
        public DataRespond GetProvince(string pid)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_IDistrictResponsitory.getDistrictByprovince(pid);
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