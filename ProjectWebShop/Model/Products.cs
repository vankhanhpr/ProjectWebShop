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
        public int prid { get; set; }
        public string prname { get; set; }
        public int total { get; set; }
        public string image1 { get; set; }
        public int importprice { get; set; }
        public int price { get; set; }
        public string lineprid { get; set; }
    }
}
