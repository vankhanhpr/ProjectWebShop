
using Newtonsoft.Json.Linq;

namespace ProjectWebShop.Model
{
    public class InvoiceProduct
    {
        //public InvoiceProduct(string json)
        //{
        //    JObject jObject = JObject.Parse(json);
        //    JToken jUser = jObject;
        //    invprid = (int)jUser["invprid"];
        //    prid = (int)jUser["prid"];
        //    total = (int)jUser["total"];
        //}
        public int invprid { get; set; }
        public int prid { get; set; }
        public int total { get; set; }
    }
}
