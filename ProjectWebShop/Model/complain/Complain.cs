using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model.complain
{
    public class Complain
    {
        [Key]
        public int cpid { get; set; }
        public string email { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public string content { get; set; }
        public DateTime createday { get; set; }
        public int status { get; set; }
    }
}
