using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApiMyShop.Data;

namespace ProjectWebShop.Responsitory
{
    public class EvaluateResponsitory : Responsitory<Evaluates>, IEvaluateResponsitory
    {
        private DbSet<Evaluates> evaluateentity;
        public EvaluateResponsitory(MyDBContext context) : base(context)
        {
            evaluateentity = context.Set<Evaluates>();
        }
        public void DeleteEvaluate(int id)
        {
            evaluateentity.Remove(GetEvaluatesById(id));
        }

        public dynamic GetAllEvaluates(int prid)
        {
            var pdt = context.Evaluates.Where(p=> p.prid==prid).Select(cmt => new
            {
                cmt,
                images = context.Imgcomments.Where(image => image.evaid == cmt.evaid).ToList()
            });
            return pdt.ToList();
        }

        public Evaluates GetEvaluatesById(int id)
        {
            return context.Evaluates
              .Where(p => p.evaid == id)
              .FirstOrDefault();
        }
        public dynamic GetEvaluatesByPr(int id)
        {
            return context.Evaluates
              .Where(p => p.evaid == id)
              .FirstOrDefault();
        }

        public void SaveEvaluate(Evaluates ev)
        {
            context.Entry(ev).State = EntityState.Added;
            context.SaveChanges();
        }

        public void UpdateEvaluate(Evaluates ev)
        {
            context.Update(ev);
            context.SaveChanges();
        }
    }
}
