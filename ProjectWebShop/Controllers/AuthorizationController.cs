﻿using System;
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
        private AuthServiceImpl m_authService;
        public AuthorizationController(IUserResponsitory userResponsitory, IConfiguration config)
        {
            this.m_userResponsitory=userResponsitory;
            this.m_config = config;
            this.m_authService = AuthServiceImpl.Instance(m_userResponsitory, m_config);
        }
        [HttpPost("login")]
        public string login([FromForm]Users user)
        {
            AuthInfo authInfo = new AuthInfo();
            authInfo.email = user.email;
            authInfo.password = user.password;
            return m_authService.login(authInfo);
        }
    }
}