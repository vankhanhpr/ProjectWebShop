using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.register;
using ProjectWebShop.Model;
using ProjectWebShop.Model.register;

namespace ProjectWebShop.Controllers.register
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : Controller
    {
        private IRegisterResponsitory m_registerResponsitory;
        public RegisterController(IRegisterResponsitory registerResponsitory)
        {
            m_registerResponsitory = registerResponsitory;
        }
        [HttpGet("GetAllRegister")]
        public DataRespond GetAllRegister(int page,int pagesize)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_registerResponsitory.GetAllRegister(page,pagesize);
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }
        
        [HttpPost("InsertRegister")]
        public DataRespond InsertRegister([FromBody] Register register)
        {
            DataRespond data = new DataRespond();
            try
            {
                Register rg = new Register();
                rg.email = register.email;
                rg.status = 0;
                data.data=m_registerResponsitory.InsertRegister(rg);
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