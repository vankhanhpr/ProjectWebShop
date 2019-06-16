using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectWebShop.Auth;
using ProjectWebShop.Auth.vo;
using ProjectWebShop.Interface.user;
using ProjectWebShop.Model;
using ProjectWebShop.Model.auth;

namespace ProjectWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : Controller
    {
        private IUserResponsitory m_userResponsitory;
        private IConfiguration m_config;
        private IAuthService m_authService;
        public AuthorizationController(IUserResponsitory userResponsitory, IConfiguration config, IAuthService auth)
        {
            m_userResponsitory=userResponsitory;
            m_config = config;
            this.m_authService = auth;
        }
        [HttpPost("login")]
        public DataRespond login([FromBody]Users user)
        {
            DataRespond data = new DataRespond();
            try
            {
                
                AuthInfo authInfo = new AuthInfo();
                authInfo.email = user.email;
                authInfo.password = user.password;
                data = m_authService.login(authInfo);
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }
        [HttpPost("checkToken")]
        public DataRespond checkToken([FromBody] Token token)
        {
            DataRespond data = m_authService.checkToken(token.email, token.token);
            return data;
        }
    }
}