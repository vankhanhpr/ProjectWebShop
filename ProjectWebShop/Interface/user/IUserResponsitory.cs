﻿using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model;
using System.Collections.Generic;
using WebApiMyShop.Models;

namespace ProjectWebShop.Interface.user
{
    public interface IUserResponsitory:IResponsitory<Users>
    {
        IEnumerable<Users> GetAllUser();
        dynamic RemoveUser();
        Users GetUserByEmail(string email);
        void DeleteUser(Users users);
        void UpdateUser(Users users);
        void InsertUser(Users users);
        IEnumerable<Users> GetUserByRoles(int idrole);
    }
}