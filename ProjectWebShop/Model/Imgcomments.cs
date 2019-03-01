using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class ImgComments
    {
        [Key]
        public int icmtid { get; set; }
        public string image { get; set; }
        public int evaid { get; set; }
    }
}
