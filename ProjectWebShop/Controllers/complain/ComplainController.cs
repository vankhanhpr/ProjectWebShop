using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.compalin;
using ProjectWebShop.Model;
using ProjectWebShop.Model.complain;

namespace ProjectWebShop.Controllers.complain
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainController : Controller
    {
        private IComplainResponsitory m_complainResponsitory;
        public ComplainController(IComplainResponsitory complainResponsitory)
        {
            m_complainResponsitory = complainResponsitory;
        }
        [HttpPost("InsertComplain")]
       public DataRespond InsertComplain(Complain complain)
        {
            DataRespond data = new DataRespond();
            try
            {
                complain.createday = DateTime.Now;
                complain.status = 0;
                m_complainResponsitory.InsertComplain(complain);
                data.success = true;
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }

        [HttpGet("GetAllComplain")]
        public DataRespond GetAllComplain(int page,int pagesize)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.data = m_complainResponsitory.GetAllComplain(page, pagesize);
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