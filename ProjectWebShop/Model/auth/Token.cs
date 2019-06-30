using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model.auth
{
    public class Token
    {
        public Token(string json)
        {
            JObject jobject = JObject.Parse(json);
            JToken juser = jobject;
            email = (string)juser["email"];
            token = (string)juser["token"];
        }
        [Key]
        public string email { get; set; }
        public string token { get; set; }
    }
}
