using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model.discount
{
    public class Discount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int discountid { get; set; }
        public int percent { get; set; }
        public string eventname { get; set; }
        public string code { get; set; }
        public double money { get; set; }
        public int stt { get; set; }
        public DateTime startday { get; set; }
        public DateTime endday { get; set; }
        public string note { get; set; }
    }
}
