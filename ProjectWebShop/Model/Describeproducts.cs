using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class Describeproducts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int desid { get; set; }
        public string title { get; set; }
        public string describes { get; set; }
        public int prid { get; set; }
        public int stt { get; set; }
    }
}
