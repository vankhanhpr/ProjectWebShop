using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.lineproduct;
using ProjectWebShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApiMyShop.Data;

namespace ProjectWebShop.Responsitory
{
    public class LineProductResponsitory:  Responsitory<LineProducts>,ILineProductResponsitory
    {
        private DbSet<LineProducts> lnproductEntity;
        public LineProductResponsitory(MyDBContext context) : base(context)
        {
            this.lnproductEntity = context.Set<LineProducts>();
        }

        public void DeleteLineProduct(int id)
        {
            LineProducts ln = GetLineById(id);
            lnproductEntity.Remove(ln);
            context.SaveChanges();
        }
        public IEnumerable<LineProducts> GetAllLine()
        {
            return context.LineProducts.ToList();
        }
        public LineProducts GetLineById(int id)
        {
            return context.LineProducts
                .Where(p => p.lineprid == id)
                .FirstOrDefault();
        }
        public void SaveLineProduct(LineProducts linep)
        {
            context.Entry(linep).State = EntityState.Added;
            context.SaveChanges();
        }
        public void UpdateLineProduct(LineProducts linep)
        {
            context.Update(linep);
            context.SaveChanges();
        }
    }
}
