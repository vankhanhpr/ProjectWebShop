using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class DescribeRespond
    {
        public DescribeRespond(string json)
        {
            JObject jobject = JObject.Parse(json);
            JToken juser = jobject;
            title = (string)juser["total"];
            describes = (string)juser["total"];
            prid = (int)juser["total"];
            stt = (int)juser["total"];
        }
        [Key]
        public int desid { get; set; }
        public string title { get; set; }
        public string describes { get; set; }
        public int prid { get; set; }
        public int stt { get; set; }
    }
}
