using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Model;
using WebApiMyShop.Data;

namespace ProjectWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private MyDBContext context;
        public ProductsController(MyDBContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public List<Products> getAllOrsereds()
        {
            return context.Products.ToList();
        }
    }
}