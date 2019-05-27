using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class UserRequest
    {
        [Key]
        public int usid { get; set; }
        public string fullname { get; set; }
        public string password { get; set; }
        public int roles { get; set; }
        public IFormFile avatar { get; set; }
        public string wall { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string birthday { get; set; }
        public string createday { get; set; }
        public int active { get; set; }
        public int gender { get; set; }
    }
}
