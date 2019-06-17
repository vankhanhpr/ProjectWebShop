using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication.Helper;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AdminController : Controller
    {
        Data data = new Data();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            //List<LineProducts> list = new List<LineProducts>();
            //HttpClient client = data.Initial();
            //HttpResponseMessage res = await client.GetAsync("LineProduct/GetAllLineProduct").ConfigureAwait(false); ;

            //if (res.IsSuccessStatusCode)
            //{
            //    var result = res.Content.ReadAsStringAsync().Result;
            //    list = JsonConvert.DeserializeObject<List<LineProducts>>(result);
            //}

            return View();
        }
        //public async Task<IActionResult> SendRequestAsyncSchedule()
        //{
        //    List<LineProducts> list = new List<LineProducts>();
        //    HttpClient client = data.Initial();
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        //    HttpResponseMessage res = await client.GetAsync("LineProduct/GetAllLineProduct").ConfigureAwait(false); ;
        //    if (res.IsSuccessStatusCode)
        //    {
        //        var result = res.Content.ReadAsStringAsync().Result;
        //        list = JsonConvert.DeserializeObject<List<LineProducts>>(result);
        //    }
        //    return View(list);
        //}
        public IActionResult AdminLogin()
        {
            return View();
        }
        public IActionResult AdminAddProduct()
        {
            return View();
        }
        public IActionResult UserAdmin()
        {
            return View();
        }
        public IActionResult Event()
        {
            return View();
        }
    }
}