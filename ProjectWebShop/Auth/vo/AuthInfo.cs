using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Auth.vo
{
    public class AuthInfo
    {
        public String email { get; set; }
        public String password { get; set; }
        public int roles { get; set; }
        public AuthInfo()
        {

        }
        public AuthInfo(String email, String password)
        {
            this.email = email;
            this.password = password;
        }
    }
}
