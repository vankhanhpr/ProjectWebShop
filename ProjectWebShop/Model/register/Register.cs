using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model.register
{
    public class Register
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int regid { get; set; }
        public string email { get; set; }
        public int status { get; set; }
        public string note { get; set; }
    }
}
