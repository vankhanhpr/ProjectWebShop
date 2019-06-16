using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Model;

namespace ProjectWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescribeProductController : Controller
    {
        private IDescribeResponsitory m_describeResponsitory;
        public DescribeProductController(IDescribeResponsitory idescribeResponsitory)
        {
            m_describeResponsitory = idescribeResponsitory;
        }
           //get by prid
           [HttpGet("GetDesPrById")]
         public DataRespond getDesPrById(int id)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.data = m_describeResponsitory.getDescriptPrById(id);
                data.success = true;
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }
        [HttpPost("CustomDesPr")]
        public DataRespond CustomDesPr([FromBody]Describeproducts des)
        {
            DataRespond data = new DataRespond();
            if (des.prid == 0)
            {
                data.success = false;
                return data;
            }
            try
            {
                var tes= m_describeResponsitory.getDescriptPrById(des.prid);

                if (tes!=null)
                {
                    tes.prid = des.prid;
                    tes.describes = des.describes;
                    tes.title = des.title;
                    tes.stt = des.stt;//0 enable else 1
                    m_describeResponsitory.updateDes(tes);
                }
                else
                {
                    m_describeResponsitory.inserDes(des);
                }
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