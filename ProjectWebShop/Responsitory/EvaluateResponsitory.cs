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
    public class EvaluateResponsitory : Responsitory<Evaluate>, IEvaluateResponsitory
    {
        private DbSet<Evaluate> evaluateentity;
        public EvaluateResponsitory(MyDBContext context) : base(context)
        {
            evaluateentity = context.Set<Evaluate>();
        }
        public void DeleteEvaluate(int id)
        {
            evaluateentity.Remove(GetEvaluatesById(id));
            context.SaveChanges();
        }

        public dynamic GetAllEvaluates()
        {
            return context.Evaluates.ToList();
        }

        public Evaluate GetEvaluatesById(int id)
        {
            return context.Evaluates
              .Where(p => p.evaid == id)
              .FirstOrDefault();
        }
        public List<Evaluate> GetEvaluatesByPr(int prid)
        {
            return context.Evaluates
              .Where(p => p.prid == prid).ToList();
        }

        public void SaveEvaluate(Evaluate ev)
        {
            context.Entry(ev).State = EntityState.Added;
            context.SaveChanges();
        }

        public void UpdateEvaluate(Evaluate ev)
        {
            context.Update(ev);
            context.SaveChanges();
        }
    }
}
