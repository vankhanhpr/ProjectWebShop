using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class InvoiceProductRequest
    {
        public InvoiceProductRequest(string json)
        {
            JObject jobject = JObject.Parse(json);
            JToken juser = jobject;
            prid = (int)juser["prid"];
            total = (int)juser["total"];
        }
        public int prid { get; set; }
        public int total { get; set; }
    }
}
