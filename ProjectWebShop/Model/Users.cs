using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class Users
    {
        [Key]
        public int usid { get; set; }
        public string fullname { get; set; }
        public string password { get; set; }
        public int roles { get; set; }
        public string avatar { get; set; }
        public string wall { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public DateTime birthday { get; set; }
        public DateTime createday { get; set; }
        public int active { get; set; }
        public int gender { get; set; }
    }
}
