using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class FileUpdate
    {
        public FileUpdate(string json)
        {
            JObject jObject = JObject.Parse(json);
            JToken jUser = jObject;
            imgid = (int)jUser["imgid"];
            image = (string)jUser["image"];
            check = (Boolean)jUser["check"];
        }
        public int imgid { get; set; }
        public string image { get; set; }
        public Boolean check { get; set; }
    }
}
