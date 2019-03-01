using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class Evaluates
    {
        [Key]
        public int evaid { get; set; }
        public string comment { get; set; }
        public int evaluate { get; set; }
        public int usid { get; set; }
        public int prid { get; set; }
        public int parentid { get; set; }
    }
}
