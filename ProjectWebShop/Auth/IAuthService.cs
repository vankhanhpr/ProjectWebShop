using ProjectWebShop.Auth.vo;
using System;

namespace ProjectWebShop.Auth
{
    public interface IAuthService
    {
        String login(AuthInfo authInfo);

        void logout();

        void refreshToken();

        Boolean validateToken(String token, string tokenClien);

        Boolean checkPass(string pass,string passClient);
    }
}
