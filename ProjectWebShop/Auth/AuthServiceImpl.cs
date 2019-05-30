using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ProjectWebShop.Auth.vo;
using ProjectWebShop.Interface.user;
using ProjectWebShop.Model;
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
        private IDictionary<String, String> m_tokens = new Dictionary<String, String>();

        //public static readonly AuthServiceImpl instance;

        //public static AuthServiceImpl Instance(IUserResponsitory userResponsitory, IConfiguration config)
        //{
        //    if (instance == null)
        //    {
        //        instance = new AuthServiceImpl(userResponsitory,config);
        //    }
        //    return instance;
        //}
        public AuthServiceImpl(IUserResponsitory userResponsitory, IConfiguration config)
        {
            m_config = config;
            m_userResponsitory = userResponsitory;
        }

        public String login(AuthInfo authInfo)
        {
            // 1. Check token if exist
            // 2. If yes, check token is valid ( Gerneate from Serect Key, Token is expire)
            // 3. If no, Genreate new token 
            Users user = findUser(authInfo);
            if (user != null)
            {
                if (checkPass(authInfo.password, user.password))
                {
                    String token = generateToken(user);
                    saveToken(user.email, token);
                    return token;
                }
            }
            return null;
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
        }

        string IAuthService.login(AuthInfo authInfo)
        {
            throw new NotImplementedException();
        }

        public bool checkPass(string pass, string passClient)
        {
            if (pass == passClient)
            {
                return true;
            }
            return false;
        }


    }
}


