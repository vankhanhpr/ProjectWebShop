using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class LineProducts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int lineprid { get; set; }
        public string linename { get; set; }
        public int status { get; set; }
    }
}
