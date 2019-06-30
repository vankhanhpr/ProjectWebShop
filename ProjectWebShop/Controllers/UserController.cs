using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.user;
using ProjectWebShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace ProjectWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserResponsitory _iuserResponsitory;
        private IHostingEnvironment _hostingEnvironment;

        public UserController(IUserResponsitory iuserResponsitory, IHostingEnvironment hostingEnvironment)
        {
            _iuserResponsitory = iuserResponsitory;
            this._hostingEnvironment = hostingEnvironment;
        }
        [HttpGet("getAllUser")]
        public dynamic GetAllUser()
        {
            return _iuserResponsitory.GetAllUser();
        }
        [HttpPost("insertUser")]
        public async Task<IActionResult> InsertUser([FromForm]UserRequest users)
        {
            try
            {
                var usud = new Users();
                usud.usid = users.usid;
                usud.fullname = users.fullname;
                usud.email = users.email;
                usud.address = users.address;
                usud.phone = users.phone;
                usud.active = users.active;
                usud.roles = users.roles;
                usud.gender = users.gender;
                usud.password = users.password;

                DateTime bd = DateTime.ParseExact(users.birthday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                usud.birthday = bd;
                DateTime createday = DateTime.ParseExact(users.createday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                usud.createday = createday;
                //save image
                var x = users.avatar.GetFilename().Split(".");
                var nameimage = RandomString(10) + "." + x[1];
                var path = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/user",
                            nameimage);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await users.avatar.CopyToAsync(stream);
                }
                usud.avatar = nameimage;
                _iuserResponsitory.InsertUser(usud);
                return Ok(new { data = "success" });
            }
            catch(Exception e)
            {
                return Ok(new { data = e});
            }
        }
        [HttpGet("getUserByRole")]
        public IEnumerable<Users> GetUserByRole(int roleid)
        {
            return _iuserResponsitory.GetUserByRoles(roleid);
        }
        //random image 
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghiklmnopqrstwz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //get user by id
        [HttpPost("getUserByEmail")]
        public Users GetUserByEmail(string email)
        {
            try
            {
                return _iuserResponsitory.GetUserByEmail(email);
            }
            catch(Exception e) {
                return null;
            }
        }
        [HttpPost("updateUser")]
        public async Task<IActionResult> UpdateUser([FromForm] UserRespontUpdate usrq)
        {
            try
            {
                Users userud = new Users();
                userud.fullname = usrq.fullname;
                userud.email = usrq.email;
                userud.address = usrq.address;
                userud.phone = usrq.phone;
                userud.usid = usrq.usid;
                userud.password = usrq.password;
                userud.roles = usrq.roles;
                userud.wall = usrq.wall;
                DateTime createday = DateTime.ParseExact(usrq.createday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                userud.createday = createday;
                userud.active = usrq.active;
                DateTime birthday = DateTime.ParseExact(usrq.birthday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                userud.birthday = birthday;

                if (usrq.newavatar != null)
                {
                    //delete old picture
                    string webRootPath = _hostingEnvironment.WebRootPath;
                    string contentRootPath = _hostingEnvironment.ContentRootPath;
                    var file = System.IO.Path.Combine(webRootPath, "user/" + usrq.avatar);
                    System.IO.File.Delete(file);//delete in forder

                    //add ne picture to forder
                    var temp = usrq.newavatar.GetFilename().Split(".");
                    var nameimgmain = RandomString(10) + "." + temp[1];
                    var fpath = Path.Combine(
                                Directory.GetCurrentDirectory(), "wwwroot/user",
                                nameimgmain);//post image to forder 
                    userud.avatar = nameimgmain;

                    using (var stream = new FileStream(fpath, FileMode.Create))
                    {
                        await usrq.newavatar.CopyToAsync(stream);
                    }
                }
                else
                {
                    userud.avatar = usrq.avatar;
                }
                _iuserResponsitory.UpdateUser(userud);
                return Ok(new { data = "success" });
            }
            catch(Exception e)
            {
                return Ok(new { data = "error" });

            }
        }
    }
}