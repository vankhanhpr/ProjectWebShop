using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.user;

namespace ProjectWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserResponsitory _iuserResponsitory;
        public UserController(IUserResponsitory iuserResponsitory)
        {
            _iuserResponsitory = iuserResponsitory;
        }
        [HttpGet("getAllUser")]
        public dynamic GetAllUser()
        {
            return _iuserResponsitory.GetAllUser();
        }
    }
}