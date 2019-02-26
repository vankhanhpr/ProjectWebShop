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
        public string image { get; set; }
        public long importprice { get; set; }
        public long price { get; set; }
        public int lineprid { get; set; }
    }
}
