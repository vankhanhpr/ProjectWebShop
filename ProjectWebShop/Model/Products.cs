using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class Products
    {

        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
