﻿using System.Threading.Tasks;
using ProjectWebShop.Model;
using System;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using ProjectWebShop.Interface.product;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace ProjectWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IProductResponsitory _iproductResponsitory;
        private readonly IImageProductResponsitory _iimageProductResponsitory;

        public FileController(IHostingEnvironment hostingEnvironment, IProductResponsitory iproductResponsitory, IImageProductResponsitory iimageProductResponsitory)
        {
            _hostingEnvironment = hostingEnvironment;
            _iproductResponsitory = iproductResponsitory;
            _iimageProductResponsitory = iimageProductResponsitory;
        }

        //https://localhost:44337/images/3pihm04qn4.jpg
        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Ok("file not selected");
            var x = file.GetFilename().Split(".");//cut jpg/png...
            var nameimage = RandomString(10) + "." + x[1];//+jpg/png
            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/image",
                        nameimage);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return Ok(new { image = nameimage });
        }
        [HttpPost("UploadListFile")]
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
                return Content("files not selected 1");
            foreach (var file in files)
            {
                var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/image",
                        file.GetFilename());

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return RedirectToAction("Files");
        }

        [HttpPost("RemoveListFile")]
        public object RemoveListFiles([FromBody]string filename)
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            var file = System.IO.Path.Combine(webRootPath, "images/" + filename);
            System.IO.File.Delete(file);
            return "OK";
        }

        [HttpPost("InseretProduct")]
        public async Task<IActionResult> InseretProduct([FromForm]ProductRespont pd)
        {
            if (pd == null)
                return Ok("Error");
            var i = pd.imagerq.GetFilename().Split(".");
            var nameimg = RandomString(10) + "." + i[1];
            var fpath = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/images",
                        nameimg);
            using (var stream = new FileStream(fpath, FileMode.Create))
            {
                await pd.imagerq.CopyToAsync(stream);
            }

            var prod = new Products();
            prod.prname = pd.prname;
            prod.total = pd.total;
            prod.lineprid = pd.lineprid;
            prod.importprice = pd.importprice;
            prod.price = pd.price;
            prod.image = nameimg;
            prod.mnday = pd.mnday;
            prod.expirydate = pd.expirydate;
            try
            {
                _iproductResponsitory.SaveProduct(prod);
            }
            catch (Exception ex)
            {

                throw;
            }
            
            foreach (var file in pd.files)
            {
                var x = file.GetFilename().Split(".");
                var nameimage = RandomString(10) + "." + x[1];
                var path = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/images",
                            nameimage);
                var img = new ImageProducts();
                img.image = nameimage;
                img.prid = prod.prid;
                _iimageProductResponsitory.SaveImg(img);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return Ok(new { data = "success" });
        }
        [HttpPost("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromForm]ProductRespont pd)
        {
            if (pd == null)
            {
                return Ok("Files not found");
            }
            Products pf=_iproductResponsitory.GetProductById(pd.prid);
            pf.prname = pd.prname;
            pf.total = pd.total;
            pf.importprice = pd.importprice;
            pf.price = pd.price;
            pf.lineprid = pd.lineprid;
            pf.totalview = pd.totalview;
            pf.totallike = pd.totallike;
            pf.evaluate = pd.evaluate;
            _iproductResponsitory.UpdateProduct(pf);
            IEnumerable <ImageProducts> listimg = _iimageProductResponsitory.GetAllImgByPrid(pd.prid);
            foreach (var img in listimg)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                string contentRootPath = _hostingEnvironment.ContentRootPath;
                var file = System.IO.Path.Combine(webRootPath, "images/" + img.image);
                System.IO.File.Delete(file);
                _iimageProductResponsitory.DeleteImg(img.imgid);
            }
            foreach(var file in pd.files)
            {
                var x = file.GetFilename().Split(".");
                var nameimage = RandomString(10) + "." + x[1];
                var path = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/images",
                            nameimage);
                var img = new ImageProducts();
                img.image = nameimage;
                img.prid = pd.prid;
                _iimageProductResponsitory.SaveImg(img);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return Ok(new { data = "success" });
        }
        [HttpPost("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                if (id == 0)
                {
                    return Ok("Product not found");
                }
                Products pf = _iproductResponsitory.GetaProductById(id);
                IEnumerable<ImageProducts> listimg = _iimageProductResponsitory.GetAllImgByPrid(pf.prid);
                foreach (var img in listimg)
                {
                    string webRootPath = _hostingEnvironment.WebRootPath;
                    string contentRootPath = _hostingEnvironment.ContentRootPath;
                    var file = System.IO.Path.Combine(webRootPath, "images/" + img.image);
                    System.IO.File.Delete(file);
                    _iimageProductResponsitory.DeleteImg(img.imgid);
                }
                _iproductResponsitory.DeleteProduct(id);
                return Ok(new { data = "Remove success" });
            }
            catch (Exception e)
            {
                return Ok(new { data = "Remove error" });
            }
            
        }
        //random image 
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghiklmnopqrstwz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}