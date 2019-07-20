using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Model.discount;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApiMyShop.Data;

namespace ProjectWebShop.Responsitory.discount
{
    public class DiscountResponsitory : Responsitory<Discount>, IDiscountResponsitory
    {
        private DbSet<Discount> discountEntity;

        public DiscountResponsitory(MyDBContext context) : base(context)
        {
            discountEntity = context.Set<Discount>();
        }
        public void CreateEvent(Discount ds)
        {
            context.Entry(ds).State = EntityState.Added;
            context.SaveChanges();
        }

        public void DeleteDiscount(string code)
        {
            Discount ds = GetDisCountByCode(code);
            discountEntity.Remove(ds);
            context.SaveChanges();
        }

        public void EditDiscount(Discount ds)
        {
            context.Update(ds);
            context.SaveChanges();
        }

        public void EnableEvent(Discount ds)
        {
            ds.stt = 1;//0 enable else 1
            context.Update(ds);
            context.SaveChanges();
        }

        public IEnumerable<Discount> FilterDiscount(string filter)
        {
            var filterby = filter.Trim().ToLowerInvariant();
            return context.Discount.ToList().AsQueryable().Where(m=>
                            m.discountid.ToString().ToLowerInvariant().Contains(filterby)
                            ||m.eventname.ToLowerInvariant().Contains(filterby)
                            ||m.percent.ToString().ToLowerInvariant().Contains(filterby)
                            ||m.code.ToLowerInvariant().Contains(filterby)
            );
        }

        public IEnumerable<Discount> GetAllDiscount(int page,int pagesize)
        {
            return context.Discount.OrderBy(x => x.endday).ToList().Skip(page*pagesize).Take(pagesize);
        }

        public Discount GetDisCountByCode(string code)
        {
            return context.Discount.Where(x => x.code == code && x.stt == 0).FirstOrDefault();
        }
    }
}
