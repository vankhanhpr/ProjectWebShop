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
        public string login([FromBody]Users user)
        {
            AuthInfo authInfo = new AuthInfo();
            authInfo.email = user.email;
            authInfo.password = user.password;
            return m_authService.login(authInfo);
        }
    }
}