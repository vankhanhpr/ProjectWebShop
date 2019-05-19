using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMyShop.Models
{
    public class UserLogin
    {
        [Key]
        public string usid { get; set; }
        public string password { get; set; }
    }
}