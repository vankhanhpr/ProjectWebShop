﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model.units
{
    public class Devvn_quanhuyen
    {
        [Key]
        public string maqh { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string matp { get; set; }
    }
}
