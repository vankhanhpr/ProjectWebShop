using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.lineproduct;
using ProjectWebShop.Model;

namespace ProjectWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineProductController : Controller
    {
        private readonly ILineProductResponsitory _ilnproductResponsitory;
        public LineProductController(ILineProductResponsitory ilnproductResponsitory)
        {
            _ilnproductResponsitory = ilnproductResponsitory;
        }
        [HttpGet("GetAllLineProduct")]
        public dynamic GetAllLine()
        {
            return _ilnproductResponsitory.GetAllLine();
        }
        [HttpPost("InsertLineProduct")]
        public dynamic InsertLine([FromBody]LineProducts ln)
        {
            if (ln!=null)
            {
                _ilnproductResponsitory.SaveLineProduct(ln);
                return Ok(new { data = "success" });
            }
            else
            {
                return Ok(new { data = "error" });
            }
        }
    }
}