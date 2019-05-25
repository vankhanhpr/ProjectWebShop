using ProjectWebShop.Interface.product;
using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApiMyShop.Data;
using WebApiMyShop.Models;
using ProjectWebShop.Interface.user;
using System.Linq;

namespace ProjectWebShop.Responsitory
{
    public class UserResponsitory : Responsitory<Users>,IUserResponsitory
    {
        private DbSet<Users> userEntity;

        public UserResponsitory(MyDBContext context) : base(context)
        {
            userEntity = context.Set<Users>();
        }

        public void DeleteUser(Users users)
        {
            Users us = GetUserByEmail(users.email);
            userEntity.Remove(us);
            context.SaveChanges();
        }

        public IEnumerable<Users> GetAllUser()
        {
            return context.Users.ToList();
        }

        public Users GetUserByEmail(string email)
        {
            return context.Users.Where(x => x.email == email).FirstOrDefault();
        }

        public IEnumerable<Users> GetUserByRoles(int idrole)
        {
            throw new NotImplementedException();
        }

        public void InsertUser(Users users)
        {
            context.Entry(users).State = EntityState.Added;
            context.SaveChanges();
        }

        public dynamic RemoveUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Users users)
        {
            context.Update(users);
            context.SaveChanges();
        }
    }
}
