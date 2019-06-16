using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product(int? prid)
        {
            int product = prid ?? 0 ;
            if (product == 0)
            {
                return RedirectToAction("index", "home");
            }
            else
            {
                ViewBag.product = product;
                return View();
            }
        }
        public IActionResult DescriptionProduct(int? prid)
        {
            int product = prid ?? 0;
            if (product == 0)
            {
                return RedirectToAction("index", "home");
            }
            else
            {
                ViewBag.prid = product;
                return View();
            }
        }
    }
}