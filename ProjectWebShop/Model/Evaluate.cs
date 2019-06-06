using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class Evaluate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  evaid { get; set; }
        public int evaluate { get; set; }
        public int prid { get; set; }
        public int usid { get; set; }
        public string note { get; set; }
    }
}
