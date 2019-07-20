using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.compalin;
using ProjectWebShop.Model.complain;
using System;
using System.Linq;
using WebApiMyShop.Data;

namespace ProjectWebShop.Responsitory.complain
{
    public class ComplainResponsitory :Responsitory<Complain>, IComplainResponsitory
    {
        private DbSet<Complain> compalinEntity;
        public ComplainResponsitory(MyDBContext context):base(context)
        {
            compalinEntity = context.Set<Complain>();
        }
        public dynamic GetAllComplain(int page, int pagesize)
        {
            return context.Complain.Where(m=>m.status==0).ToList().Skip(page*pagesize).Take(pagesize);
        }

        public void InsertComplain(Complain complain)
        {
            context.Entry(complain).State = EntityState.Added;
            context.SaveChanges();
        }
    }
}
