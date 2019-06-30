using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ProjectWebShop.Auth.vo;
using ProjectWebShop.Interface.user;
using ProjectWebShop.Model;
using ProjectWebShop.Responsitory;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProjectWebShop.Auth
{
    public class AuthServiceImpl : IAuthService
    {

        private IUserResponsitory m_userResponsitory;

        private IConfiguration m_config;
        private static IDictionary<string, string> m_tokens = new Dictionary<string, string>();
        private static List<string> listtk = new List<string>();

        public  AuthServiceImpl(IUserResponsitory userResponsitory, IConfiguration config)
        {
            m_config = config;
            m_userResponsitory = userResponsitory;
        }

        public DataRespond login(AuthInfo authInfo)
        {
            DataRespond data = new DataRespond();
            Users user = findUser(authInfo);
            if (user != null)
            {
                if (checkPass(authInfo.password, user.password))
                {
                    data.success = true;
                    string token = generateToken(user);
                    listtk.Add(token);
                    saveToken(user.email, token);
                    data.data = new{ token= token,email=user.email,roles=user.roles};
                }
                else
                {
                    data.success = false;
                    data.data = "Nhập mật khẩu không chính xác";
                }
            }
            else
            {
                data.success = false;
                data.data = "Email chưa được đăng kí tài khoản";
            }
            return data;
        }

        private void saveToken(String email, String token)
        {
            m_tokens.Add(email, token);
        }

        private String generateToken(Users user)
        {
            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, user.fullname),
                new Claim(JwtRegisteredClaimNames.Email, user.email),
                //new Claim(JwtRegisteredClaimNames.Birthdate, user.Birthdate.ToString("yyyy-MM-dd")),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(m_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(m_config["Jwt:Issuer"],
                m_config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(30), //expire time là 30 phút
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public void logout()
        {
            throw new NotImplementedException();
        }

        public void refreshToken()
        {
            throw new NotImplementedException();
        }

        public Boolean validateToken(string token, string tokenClient)
        {
            // 1. Check this token is gereated from Serect Key
            // 2. Check is token expire  retturn false

            if (isEmpty(tokenClient))
            {
                return true;
            }
            return false;
        }

        private Users findUser(AuthInfo authInfoFromClient)
        {
            if (authInfoFromClient == null)
            {
                return null;
            }
            return getUserByEmail(authInfoFromClient.email);
        }

        private Boolean isEmpty(String str)
        {
            return str == null || str.Length == 0;
        }

        private Users getUserByEmail(String email)
        {
            return m_userResponsitory.GetUserByEmail(email);
           // return _userResponsitory.GetUserByEmail(email);
        }

        public bool checkPass(string pass, string passClient)
        {
            if (pass == passClient)
            {
                return true;
            }
            return false;
        }

        public DataRespond checkToken(string email,string token)
        {
            DataRespond data = new DataRespond();

            foreach (KeyValuePair<string, string> item in m_tokens)
            {
                if (item.Key == email && item.Value == token)
                {
                    data.success = true;
                    return data;
                }
            }
            data.success = false;
            return data;
        }
    }
}


