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

        public int Count(Func<UserLogin, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(UserLogin entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserLogin entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserLogin> Find(Func<UserLogin, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAllUser()
        {
            return context.Users.ToList();
        }

        public Users GetUserByEmail(string email)
        {
            return context.Users.Where(x => x.email == email).FirstOrDefault();
        }

        public dynamic RemoveUser()
        {
            throw new NotImplementedException();
        }

        public void Update(UserLogin entity)
        {
            throw new NotImplementedException();
        }
    }
}
