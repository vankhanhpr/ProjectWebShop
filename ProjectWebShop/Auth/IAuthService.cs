using ProjectWebShop.Auth.vo;
using ProjectWebShop.Model;
using System;

namespace ProjectWebShop.Auth
{
    public interface IAuthService
    {
        DataRespond login(AuthInfo authInfo);

        void logout(string email);

        void refreshToken();

        Boolean validateToken(String token, string tokenClien);

        Boolean checkPass(string pass,string passClient);

        DataRespond checkToken(string token,string email);
    }
}
