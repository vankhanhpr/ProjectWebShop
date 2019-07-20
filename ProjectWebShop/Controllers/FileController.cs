using System.Threading.Tasks;
using ProjectWebShop.Model;
using System;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using ProjectWebShop.Interface.product;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace ProjectWebShop.Controllers
{
    [Route("api/file")]
    [ApiController]
    public class FileController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private IProductResponsitory _iproductResponsitory;
        private IImageProductResponsitory _iimageProductResponsitory;

        //private AuthService authService;
        public FileController(IHostingEnvironment hostingEnvironment, IProductResponsitory iproductResponsitory, IImageProductResponsitory iimageProductResponsitory)
        {
            this._hostingEnvironment = hostingEnvironment;
            this._iproductResponsitory = iproductResponsitory;
            this._iimageProductResponsitory = iimageProductResponsitory;
            //authService 

        }

        //https://localhost:44337/images/3pihm04qn4.jpg
        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            // 1. get Token from Header
            // 2. Call validateToken from AuthService
            // 3.
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
            {
                return Ok("Error");
            }

            try
            {
                var i = pd.imagerq.GetFilename().Split(".");
                var nameimg = RandomString(10) + "." + i[1];
                var fpath = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/images",
                            nameimg);//post image to forder 
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
                prod.oldprice = pd.oldprice;
                prod.image = nameimg;
                prod.highlight = pd.highlight;
                prod.status = 0;
                DateTime mnday = DateTime.ParseExact(pd.mnday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                prod.mnday = mnday;
                DateTime expirydate = DateTime.ParseExact(pd.expirydate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                prod.expirydate = expirydate;

                DateTime createday = DateTime.ParseExact(pd.createday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                prod.createday = createday;

                _iproductResponsitory.SaveProduct(prod);

                if (pd.files != null || pd.files.Count > 0)
                {
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
                }
            }
            catch (Exception ex)
            {
                return Ok(new { data = "error" });
            }
            return Ok(new { data = "success" });
        }
        [HttpPost("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromForm]ProductRpUpdate pd)
        {
            if (pd == null)
            {
                return Ok("Files not found");
            }
            try
            {
                //var pf = _iproductResponsitory.GetProductById(pd.prid);
                Products newitem = new Products();
                newitem.prid = pd.prid;
                newitem.prname = pd.prname;
                newitem.total = pd.total;
                newitem.importprice = pd.importprice;
                newitem.price = pd.price;
                newitem.lineprid = pd.lineprid;
                newitem.totalview = pd.totalview;
                newitem.totallike = pd.totallike;
                newitem.highlight = pd.highlight;
                newitem.oldprice = pd.oldprice;
                newitem.status = 0;
                DateTime mnday = DateTime.ParseExact(pd.mnday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                newitem.mnday = mnday;
                DateTime expirydate = DateTime.ParseExact(pd.expirydate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                newitem.expirydate = expirydate;
                DateTime createday = DateTime.ParseExact(pd.createday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                newitem.createday = createday;

                newitem.image = pd.image;
                if (pd.imagerq != null)
                {
                    //delete old picture
                    string webRootPath = _hostingEnvironment.WebRootPath;
                    string contentRootPath = _hostingEnvironment.ContentRootPath;
                    var file = System.IO.Path.Combine(webRootPath, "images/" + pd.image);
                    System.IO.File.Delete(file);//delete in forder


                    var temp = pd.imagerq.GetFilename().Split(".");
                    var nameimgmain = RandomString(10) + "." + temp[1];
                    var fpath = Path.Combine(
                                Directory.GetCurrentDirectory(), "wwwroot/images",
                                nameimgmain);//post image to forder 
                    newitem.image = nameimgmain;

                    using (var stream = new FileStream(fpath, FileMode.Create))
                    {
                        await pd.imagerq.CopyToAsync(stream);
                    }
                }
                _iproductResponsitory.UpdateProduct(newitem);
                IEnumerable<ImageProducts> listimg = _iimageProductResponsitory.GetAllImgByPrid(pd.prid);
                if (pd.filesolds != null)
                {
                    foreach (var imgrp in pd.filesolds)
                    {
                        FileUpdate fileul = new FileUpdate(imgrp);
                        if (!fileul.check)
                        {
                            string webRootPath = _hostingEnvironment.WebRootPath;
                            string contentRootPath = _hostingEnvironment.ContentRootPath;
                            var file = System.IO.Path.Combine(webRootPath, "images/" + fileul.image);
                            System.IO.File.Delete(file);//delete in forder
                            _iimageProductResponsitory.DeleteImg(fileul.imgid);//delete in database
                        }
                    }
                }
                if (pd.files.Count() > 0)
                {
                    foreach (var file in pd.files)
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
                }
                return Ok(new { data = "success" });
            }
            catch (Exception e)
            {
                return Ok(new { data = "error" });
            }
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
                //IEnumerable<ImageProducts> listimg = _iimageProductResponsitory.GetAllImgByPrid(pf.prid);
                //foreach (var img in listimg)
                //{
                //    deleteImg(img.image);
                //    _iimageProductResponsitory.DeleteImg(img.imgid);
                //}
                //deleteImg(pf.image);
                //_iproductResponsitory.DeleteProduct(id);
                pf.status = 1;
                _iproductResponsitory.UpdateProduct(pf);
                return Ok(new { data = "Remove success" });
            }
            catch (Exception e)
            {
                return Ok(new { data = "Remove error" });
            }

        }
        //delete file in foder root/image
        public void deleteImg(string img)
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            var file = System.IO.Path.Combine(webRootPath, "images/" + img);
            System.IO.File.Delete(file);
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