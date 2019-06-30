using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model.auth
{
    public class TokenRespond
    {
        [Key]
        public string json { get; set; }
    }
}
