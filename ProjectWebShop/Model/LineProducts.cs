using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class LineProducts
    {
        [Key]
        public int lineprid { get; set; }
        public string linename { get; set; }
    }
}
