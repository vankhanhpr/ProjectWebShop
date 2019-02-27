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
<<<<<<< HEAD
        public int importprice { get; set; }
        public int price { get; set; }
        public string lineprid { get; set; }
=======
        public long importprice { get; set; }
        public long price { get; set; }
        public int lineprid { get; set; }
>>>>>>> 812a570574fd07dafcc527858df96b137123a2d6
    }
}
