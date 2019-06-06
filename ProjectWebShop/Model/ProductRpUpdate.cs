using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectWebShop.Model
{
    public class ProductRpUpdate
    {
        [Key]
        public int prid { get; set; }
        public string prname { get; set; }
        public int total { get; set; }
        public long importprice { get; set; }
        public long price { get; set; }
        public long oldprice { get; set; }
        public string image { get; set; }
        public int lineprid { get; set; }
        public int totalview { get; set; }
        public int totallike { get; set; }
        public string mnday { get; set; }
        public string expirydate { get; set; }
        public string createday { get; set; }
        public int highlight { get; set; }
        public IFormFile imagerq { get; set; }
        public List<IFormFile> files { get; set; }
        public List<string> filesolds { get; set; }
    }
}
