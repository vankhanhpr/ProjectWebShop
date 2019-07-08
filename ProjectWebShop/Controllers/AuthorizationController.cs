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
            m_userResponsitory = userResponsitory;
            m_config = config;
            m_authService = auth;
        }
        [HttpPost("login")]
        public DataRespond login([FromBody]UserRequest user)
        {
            DataRespond data = new DataRespond();
            try
            { 
                AuthInfo authInfo = new AuthInfo();
                authInfo.email = user.email;
                authInfo.password = user.password;
                authInfo.roles = user.roles;
                data = m_authService.login(authInfo);
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }

        [HttpPost("signin")]
        public DataRespond signin([FromBody]UserRequest user)
        {
            DataRespond data = new DataRespond();
            try{
                if (!(m_userResponsitory.checkEmailExist(user.email)))
                {
                    data.success = false;
                    data.data = "Email này đã được đăng kí tài khoản trước đó";
                    return data;
                }
                var usud = new Users();
                usud.email = user.email;
                usud.password = user.password;
                m_userResponsitory.InsertUser(usud);
                data.success = true;
            }
            catch (Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }

        [HttpPost("checkToken")]
        public DataRespond checkToken([FromBody]TokenRespond tokenrq)
        {
            var token = new Token(tokenrq.json);
            DataRespond data = m_authService.checkToken(token.email, token.token);
            return data;
        }

        [HttpPost("signout")]
        public DataRespond signout([FromBody]UserSignOut user)
        {
            DataRespond data = new DataRespond();
            try
            {
                m_authService.logout(user.email);
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