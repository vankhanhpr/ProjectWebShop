using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Order()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult OrderSuccess(int? ivid)
        {
            int  iv = ivid ?? 0;
            if (iv == 0)
            {
                return RedirectToAction("index", "home");
            }
            else
            {
                ViewBag.ivid = iv;
                return View();
            }
        }
    }
}