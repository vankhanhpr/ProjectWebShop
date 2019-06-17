using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model.discount
{
    public class DiscountRespond
    {
        [Key]
        public int discountid { get; set; }
        public int percent { get; set; }
        public string eventname { get; set; }
        public string code { get; set; }
        public double money { get; set; }
        public int stt { get; set; }
        public string startday { get; set; }
        public string endday { get; set; }
        public string note { get; set; }
    }
}
