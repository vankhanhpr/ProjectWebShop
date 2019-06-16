using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class DataRespond
    {
        public Boolean success { get; set; }
        public dynamic data { get; set; }
        public dynamic error { get; set; }
    }
}
