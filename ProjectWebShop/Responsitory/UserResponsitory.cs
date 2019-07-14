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

        public bool CheckEmailExist(string email)
        {
            Users us = context.Users.Where(x => x.email == email).FirstOrDefault();
            if (us != null)
            {
                return false;
            }
            return true;
        }
        public void DeleteUser(Users users)
        {
            Users us = GetUserByEmail(users.email);
            userEntity.Remove(us);
            context.SaveChanges();
        }

        public IEnumerable<Users> FilterBySearchBox(int role,string filter)
        {
            var filterby = filter.Trim().ToLowerInvariant();
            return context.Users.ToList().AsQueryable().Where(m=>
                                        m.usid.ToString().ToLowerInvariant().Contains(filterby)
                                        || m.fullname.ToLowerInvariant().Contains(filterby)
                                        || m.phone.ToString().ToLowerInvariant().Contains(filterby)
                                        || m.address.ToString().ToLowerInvariant().Contains(filterby)
                                        );
        }

        public IEnumerable<Users> GetAllUser()
        {
            return context.Users.ToList();
        }

        public Users GetUserByEmail(string email)
        {
            return context.Users.Where(x => x.email == email).FirstOrDefault();
        }
        public Users GetUserByEmailRole(string email,int roles)
        {
            return context.Users.Where(x => x.email == email && x.roles == roles).FirstOrDefault();
        }
        public IEnumerable<Users> GetUserByRoles(int idrole,int page,int pagesize)
        {
            return context.Users.Where(x => x.roles == idrole).ToList().Skip(page*pagesize).Take(10);
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
