using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class InvoiceProduct
    {
        [Key]
        public int invprid { get; set; }
        public int prid { get; set; }
        public int total { get; set; }
        public int ivid { get; set; }
    }
}
