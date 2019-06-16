using ProjectWebShop.Interface.product;
using ProjectWebShop.Model;
using WebApiMyShop.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProjectWebShop.Responsitory
{
    public class DescribeResponsitory : Responsitory<Describeproducts>, IDescribeResponsitory
    {
        private DbSet<Describeproducts> desentity;
        public DescribeResponsitory(MyDBContext context): base(context)
        {
            desentity = context.Set<Describeproducts>();
        }

        public void delateDes(Describeproducts des)
        {
            desentity.Remove(des);
            context.SaveChanges();
        }

        public dynamic getAllDescript()
        {
            return context.Describeproducts.ToList();
        }

        public dynamic getDescriptPrById(int prid)
        {
            return context.Describeproducts.Where(x => x.prid == prid).FirstOrDefault();
        }

        public void inserDes(Describeproducts des)
        {
            context.Entry(des).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateDes(Describeproducts des)
        {
            context.Update(des);
            context.SaveChanges();
        }
    }
}
