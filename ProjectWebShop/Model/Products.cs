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
        public string prid { get; set; }
        public string prname { get; set; }
        public int total { get; set; }
        public string image { get; set; }
        public int importprice { get; set; }
        public int price { get; set; }
        public string lineprid { get; set; }
    }
}
