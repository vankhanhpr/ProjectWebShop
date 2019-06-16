using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model.auth
{
    public class Token
    {
        [Key]
        public string email { get; set; }
        public string token { get; set; }
    }
}
